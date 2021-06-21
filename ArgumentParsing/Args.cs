using ArgumentParsing.ArgumentMarshaler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArgumentParsing
{
	
	public class Args
	{
		private string schema;
		private string[] args;
		private bool valid = true;
		HashSet<char> unexpectedArguments = new HashSet<char>();
		Dictionary<char, BoolArgumentMarshaler> booleanArgs = new Dictionary<char, BoolArgumentMarshaler>();
		Dictionary<char, StringArgumentMarshaler> stringArgs = new Dictionary<char, StringArgumentMarshaler>();
		Dictionary<char, IntArgumentMarshaler> intArgs = new Dictionary<char, IntArgumentMarshaler>();
		HashSet<char> argsFound = new HashSet<char>();
		private int currentArgument;
		private char errorArgumentId = '\0';
		private string errorParameter = "TILT";
		ErrorCode errorCode = ErrorCode.Ok;


		


		public Args(string schema, string[] args)
		{
			this.schema = schema;
			this.args = args;
			valid = Parse();
		}


		bool Parse()
		{
			if (schema.Length == 0 && args.Length == 0)
			{
				return true;
			}
			ParseSchema();
			try
			{
				ParseArguments();
			}
			catch (ArgsException)
			{

			}

			return valid;
		}



		bool ParseSchema()
		{
			foreach(string element in schema.Split('.'))
			{
				if (element.Length > 0)
				{
					string trimmedElement = element.Trim();
					ParseSchemaElement(trimmedElement);
				}
			}
			return true;
		}


		void ParseSchemaElement(string element)
		{
			char elementId = element[0];
			string elementTail = element.Substring(1);
			ValidateSchemaElementId(elementId);
			if (IsBooleanSchemaElement(elementTail))
			{
				ParseBooleanSchemaElement(elementId);
			}
			else if (IsStringSchemaElement(elementTail))
			{
				ParseStringSchemaElement(elementId);
			}
			else if (IsIntegerSchemaElement(elementTail))
			{
				ParseIntegerSchemaElement(elementId);
			}
			else
			{
				throw new ArgsException(ErrorCode.InvalidArgumentFormat, elementId, elementTail);
			}
		}


		void ValidateSchemaElementId(char elementId)
		{
			if (!char.IsLetter(elementId))
			{
				throw new ArgsException(ErrorCode.InvalidArgumentName, elementId, null);
			}
		}


		void ParseBooleanSchemaElement(char elementId)
		{
			booleanArgs.Add(elementId, new BoolArgumentMarshaler());
		}


		void ParseIntegerSchemaElement(char elementId)
		{
			intArgs.Add(elementId, new IntArgumentMarshaler());
		}


		void ParseStringSchemaElement(char elementId)
		{
			stringArgs.Add(elementId, new StringArgumentMarshaler());
		}


		private bool IsStringSchemaElement(string elementTail)
		{
			return elementTail == "*";
		}


		private bool IsBooleanSchemaElement(string elementTail)
		{
			return elementTail.Length == 0;
		}


		private bool IsIntegerSchemaElement(string elementTail)
		{
			return elementTail == "#";
		}


		void ParseArguments()
		{
			for (currentArgument = 0; currentArgument < args.Length; currentArgument++)
			{
				string arg = args[currentArgument];
				ParseArgument(arg);
			}
		}


		void ParseArgument(string arg)
		{
			if (arg.StartsWith("-"))
			{
				ParseElements(arg);
			}
		}


		void ParseElements(string arg)
		{
			for (int i = 1; i < arg.Length; i++)
			{
				ParseElement(arg[i]);
			}
		}


		void ParseElement(char argChar)
		{
			if (SetArgument(argChar))
			{
				argsFound.Add(argChar);
			}
			else
			{
				unexpectedArguments.Add(argChar);
				errorCode = ErrorCode.UnexpectedArgument;
				valid = false;
			}
		}


		bool SetArgument(char argChar)
		{
			if (IsBooleanArg(argChar))
			{
				SetBooleanArg(argChar, true);
			}
			else if (IsStringArg(argChar))
			{
				SetStringArg(argChar);
			}
			else if (IsIntArg(argChar))
			{
				SetIntArg(argChar);
			}
			else
			{
				return false;
			}
			return true;
		}


		bool IsIntArg(char argChar)
		{
			return intArgs.ContainsKey(argChar);
		}

		void SetIntArg(char argChar)
		{
			currentArgument++;
			string parameter = null;
			IntArgumentMarshaler marshaler;

			if(!intArgs.TryGetValue(argChar, out marshaler))
            {
				throw new ArgsException(ErrorCode.UnexpectedArgument, argChar.ToString());
            }
			try
			{
				parameter = args[currentArgument];
				marshaler.Set(parameter);
				argsFound.Add(argChar);
			}
			catch (IndexOutOfRangeException e)
			{
				valid = false;
				errorArgumentId = argChar;
				errorCode = ErrorCode.MissingInteger;
				throw new ArgsException();
			}
			catch (FormatException e)
			{
				valid = false;
				errorArgumentId = argChar;
				errorParameter = parameter;
				errorCode = ErrorCode.InvalidInteger;
				throw new ArgsException();
			}
		}


		void SetStringArg(char argChar)
		{
			currentArgument++;
			try
			{
				stringArgs.Add(argChar, args[currentArgument]);
			}
			catch (IndexOutOfRangeException e)
			{
				valid = false;
				errorArgumentId = argChar;
				errorCode = ErrorCode.MissingString;
				throw new ArgsException();
			}
		}


		bool IsStringArg(char argChar)
		{
			return stringArgs.ContainsKey(argChar);
		}

		void SetBooleanArg(char argChar, bool value)
		{
			booleanArgs.Add(argChar, value);
		}

		bool IsBooleanArg(char argChar)
		{
			return booleanArgs.ContainsKey(argChar);
		}

		public int Cardinality()
		{
			return argsFound.Count;
		}
		
		public string Usage()
		{
			if (schema.Length > 0)
			{
				return "-[" + schema + "]";
			}
			else
			{
				return "";
			}
		}

		
		public string ErrorMessage()
		{
            switch (errorCode)
			{
				case ErrorCode.Ok:
					throw new Exception("TILT: Should not get here.");
				case ErrorCode.UnexpectedArgument:
					return UnexpectedArgumentMessage();
				case ErrorCode.MissingString:
					return string.Format("Could not find string parameter for {0}.",
						errorArgumentId);
				case ErrorCode.InvalidInteger:
					return string.Format("Argument {0} expects an integer but was {1}.",
						errorArgumentId, errorParameter);
				case ErrorCode.MissingInteger:
					return string.Format("Could not find integer parameter for {0}.",
						errorArgumentId);
			}
			return "";
		}


		string UnexpectedArgumentMessage()
		{
			StringBuilder message = new StringBuilder("Argument(s) -");
			foreach (char c in unexpectedArguments)
			{
				message.Append(c);
			}
			message.Append(" unexpected.");
			return message.ToString();
		}


		bool FalseIfNull(bool b)
		{
			return b != null && b;
		}


		int ZeroIfNull(int i)
		{
			return i == null ? 0 : i;
		}


		string BlankIfNull(string s)
		{
			return s ?? "";
		}


		public string GetString(char arg)
		{
			return BlankIfNull(stringArgs[arg]);
		}


		public int GetInt(char arg)
		{
			return ZeroIfNull(intArgs[arg]);
		}


		public bool GetBoolean(char arg)
		{
			return FalseIfNull(booleanArgs[arg]);
		}


		public bool Has(char arg)
		{
			return argsFound.Contains(arg);
		}


		public bool IsValid()
		{
			return valid;
		}
	}
}

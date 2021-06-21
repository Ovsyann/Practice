using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArgumentParsing
{
	enum ErrorCode
	{
		Ok,
		MissingString,
		MissingInteger,
		InvalidInteger,
		InvalidDouble,
		MissingDouble,
		InvalidArgumentName,
		InvalidArgumentFormat,
		UnexpectedArgument
	}
}

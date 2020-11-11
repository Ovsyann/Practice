using System;
using System.Linq;

namespace PolynomialTask
{
    public class Polynomial : IEquatable<Polynomial>
    {
        private readonly int[] coefficients;

        public Polynomial(int[] coefficients)
        {
            if (coefficients == null)
            {
                throw new ArgumentNullException(nameof(coefficients));
            }
            if (coefficients.Length == 0)
            {
                throw new InvalidOperationException(string.Format("Argument {0} ltngth = 0", coefficients));
            }

            this.coefficients = Clone(coefficients);
        }

        public Polynomial(Polynomial polynomial)
        {
            if (polynomial == null)
            {
                throw new ArgumentNullException("polynomial");
            }
            if (polynomial.Length == 0)
            {
                throw new InvalidOperationException(string.Format("Argument {0} length = 0", polynomial));
            }

            this.coefficients = Clone(polynomial);
        }

        private static int[] Clone(Polynomial polynomial)
        {
            int[] numbers = new int[polynomial.Length];
            for (int i = 0; i < polynomial.Length; i++)
            {
                numbers[i] = polynomial[i];
            }

            return numbers;
        }

        private static int[] Clone(int[] coefficients)
        {
            int[] numbers = new int[coefficients.Length];
            for(int i = 0; i < coefficients.Length; i++)
            {
                numbers[i] = coefficients[i];
            }

            return numbers;
        }

        public int this[int i]
        {
            get
            {
                return coefficients[i];
            }
            set
            {
                coefficients[i] = value;
            }
        }

        public int Degree
        {
            get
            {
                for(int i = coefficients.Length - 1; i > 0; i--)
                {
                    if (this[i] != 0)
                    {
                        return i;
                    }
                }

                return 0;
            }
        }

        public int Length
        {
            get
            {
                return coefficients.Length;
            }
        }

        public override int GetHashCode()
        {
            int hashCode = 0;
            for(int i = 0; i < Length; i++)
            {
                hashCode = 33 * hashCode + coefficients[i];
            }

            return hashCode;
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Polynomial);
        }

        public bool Equals(Polynomial other)
        {
            if (object.ReferenceEquals(other, null))
            {
                return false;
            }

            if (object.ReferenceEquals(this, other))
            {
                return true;
            }

            if (this.GetType() != other.GetType())
            {
                return false;
            }

            if(this.Degree != other.Degree)
            {
                return false;
            }

            for(int i = 0; i < this.Length; i++)
            {
                for(int j = 0; j < other.Length; j++)
                {
                    if(i == j && this[i] != other[j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static Polynomial operator +(Polynomial left, Polynomial right)
        {
            if (left == null)
            {
                throw new ArgumentNullException(nameof(left));
            }
            if (right == null)
            {
                throw new ArgumentNullException(nameof(right));
            }

            int newLength = Math.Max(left.Length, right.Length);
            int[] coefficients = new int[newLength];
            for(int i = 0; i < coefficients.Length; i++)
            {
                if (i < left.Length)
                {
                    coefficients[i] += left[i];
                }
                if (i < right.Length)
                {
                    coefficients[i] += right[i];
                }
            }

            return new Polynomial(coefficients);
        }

        public static Polynomial operator -(Polynomial left, Polynomial right)
        {
            if (left == null)
            {
                throw new ArgumentNullException("left");
            }
            if (right == null)
            {
                throw new ArgumentNullException("right");
            }

            int[] coefficients = new int[Math.Max(left.Length, right.Length)];
            for (int i = 0; i < coefficients.Length; i++)
            {
                int leftValue = 0;
                int rightValue = 0;

                if (i < left.Length)
                {
                    leftValue = left[i];
                }
                if (i < right.Length)
                {
                    rightValue = right[i];
                }

                coefficients[i] = leftValue - rightValue;
            }

            return new Polynomial(coefficients);
        }

        public static Polynomial operator *(Polynomial left, Polynomial right)
        {
            if (left == null)
            {
                throw new ArgumentNullException(string.Format("Polynomial {0} is null", left));
            }
            if (right == null)
            {
                throw new ArgumentNullException(string.Format("Polynomial {0} is null", right));
            }

            int[] coefficients = new int[left.Length * right.Length];
            int k;
            for(int i = 0; i < left.Length; i++)
            {
                for(int j = 0; j < right.Length; j++)
                {
                    k = i + j;
                    coefficients[k] += left[i] * right[j];
                }
            }

            return new Polynomial(coefficients);
        }

        public static Polynomial operator *(Polynomial polynomial, int value)
        {
            if (polynomial == null)
            {
                throw new ArgumentNullException(string.Format("Polynomial {0} is null", polynomial));
            }

            int[] coefficients = new int[polynomial.Length];
            for(int i = 0; i < polynomial.Length; i++)
            {
                coefficients[i] = polynomial[i] * value;
            }

            return new Polynomial(coefficients);
        }

        public static Polynomial operator *(int value, Polynomial polynomial)
        {
            if (polynomial == null)
            {
                throw new ArgumentNullException(string.Format("Polynomial {0} is null", polynomial));
            }

            int[] coefficients = new int[polynomial.Length];
            for (int i = 0; i < polynomial.Length; i++)
            {
                coefficients[i] = polynomial[i] * value;
            }

            return new Polynomial(coefficients);
        }

        public static bool operator ==(Polynomial left, Polynomial right)
        {
            if (Object.ReferenceEquals(left, null))
            {
                if (Object.ReferenceEquals(right, null))
                {
                    return true;
                }
            }

            return left.Equals(right);
        }

        public static bool operator !=(Polynomial left, Polynomial right)
        {
            return !(left == right);
        }

        public override string ToString()
        {
            string stringRepresentation = "";

            for(int i = 0; i < Length; i++)
            {
                string formatString = i == 0 ? "{0:0; - 0}X^{1}" : "{0: + 0; - 0}X^{1}";
                stringRepresentation += string.Format(formatString, this[i], i);
            }

            return stringRepresentation;
        }

        public string ToStringSignificantOnly()
        {
            string stringRepresentation = "";
            string formatString = "";
            int counter = 0;

            for(int i = 0; i < Length; i++)
            {
                if (this[i] != 0)
                {
                    counter++;
                }
            }
            if (counter == 0)
            {
                return "0";
            }

            for (int i = Length-1; i >= 0; i--)
            {
                //!!! = this[i];
                if (this[i] != 0 && i != 1 && this[i] != 1 && this[i] != -1 && i != 0)
                {
                    formatString = i == (Length - 1) ? "{0:0; - 0}X^{1}" : "{0: + 0; - 0}X^{1}";
                    stringRepresentation += string.Format(formatString, this[i], i);
                }
                else if (this[i] != 0 && this[i] != 1 && this[i] != -1 && i != 0)
                {
                    formatString = i == (Length - 1) ? "{0:0; - 0}X" : "{0: + 0; - 0}X";
                    stringRepresentation += string.Format(formatString, this[i]);
                }
                else if (this[i] != 0 && i == 0)
                {
                    formatString = "{0: + 0; - 0}";
                    stringRepresentation += string.Format(formatString, this[i]);
                }
                else if ((this[i] == 1 || this[i] == -1) && (i == 1))
                {
                    formatString = i == (Length - 1) ? "{0:; - }X" : "{0:; - }X";
                    stringRepresentation += string.Format(formatString, this[i]);
                }
                else if ((this[i] == 1 || this[i] == -1) && i != 0)
                {
                    formatString = i == (Length - 1) ? "{0:; - }X" : "{0: + ; - }X";
                    stringRepresentation += string.Format(formatString, this[i]);
                }
            }

            return stringRepresentation;
        }
    }
}
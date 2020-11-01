﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace PolynomialTask
{
    public class Polynomial : IEquatable<Polynomial>
    {
        private int degree;

        private Polynomial(int[] odds)
        {
            Odds = (int[])odds.Clone();
        }

        private Polynomial(Polynomial polynomial)
        {
            Odds = (int[])polynomial.Odds.Clone();
        }

        public static Polynomial TryCreate(int[] odds)
        {
            if (odds == null)
            {
                throw new ArgumentNullException(string.Format("Argument {0} is null", odds));
            }
            if (odds.Length == 0)
            {
                throw new InvalidOperationException(string.Format("Argument {0} ltngth = 0", odds));
            }

            return new Polynomial(odds);
        }

        public static Polynomial TryCreate(Polynomial polynomial)
        {
            if (polynomial == null)
            {
                throw new ArgumentNullException(string.Format("Argument {0} is null", polynomial));
            }
            if (polynomial.Length == 0)
            {
                throw new InvalidOperationException(string.Format("Argument {0} ltngth = 0", polynomial));
            }

            return new Polynomial(polynomial);
        }

        public int[] Odds { get; private set; }

        public int this[int i]
        {
            get
            {
                return Odds[i];
            }
            
        }
        public int Degree
        {
            get
            {
                for(int i = 0; i < Odds.Length; i++)
                {
                    if (i != 0)
                    {
                        degree = i;
                    }
                }

                return degree;
            }
        }
        public int Length
        {
            get
            {
                return Odds.Length;
            }
        }

        public override int GetHashCode()
        {
            int hashCode = 0;
            for(int i = 0; i < Length; i++)
            {
                hashCode += Odds[i] * 1000 / 100;
            }

            return hashCode;
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Polynomial);
        }

        public bool Equals(Polynomial other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return false;
            }

            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }

            if (this.GetType() != other.GetType())
            {
                return false;
            }

            return Enumerable.SequenceEqual(this.Odds,other.Odds);
        }

        public static Polynomial operator +(Polynomial left, Polynomial right)
        {
            if (left == null)
            {
                throw new ArgumentNullException(string.Format("Polynomial {0} is null", left));
            }
            if (right == null)
            {
                throw new ArgumentNullException(string.Format("Polynomial {0} is null", right));
            }

            int[] odds;
            if (left.Length > right.Length)
            {
                int i;
                odds = new int[left.Length];
                for(i = 0; i < right.Length; i++)
                {
                    odds[i] = right[i] + left[i];
                }
                for(int j = i; j < left.Length; j++)
                {
                    odds[j] = left[j];
                }
            }
            else
            {
                int i;
                odds = new int[right.Length];
                for (i = 0; i < left.Length; i++)
                {
                    odds[i] = right[i] + left[i];
                }
                for (int j = i; j < right.Length; j++)
                {
                    odds[j] = right[j];
                }
            }

            return new Polynomial(odds);
        }

        public static Polynomial operator -(Polynomial left, Polynomial right)
        {
            if (left == null)
            {
                throw new ArgumentNullException(string.Format("Polynomial {0} is null", left));
            }
            if (right == null)
            {
                throw new ArgumentNullException(string.Format("Polynomial {0} is null", right));
            }

            int[] odds;
            if (left.Length > right.Length)
            {
                int i;
                odds = new int[left.Length];
                for (i = 0; i < right.Length; i++)
                {
                    odds[i] = left[i]-right[i];
                }
                for (int j = i; j < left.Length; j++)
                {
                    odds[j] = -left[j];
                }
            }
            else
            {
                int i;
                odds = new int[right.Length];
                for (i = 0; i < left.Length; i++)
                {
                    odds[i] = right[i] - left[i];
                }
                for (int j = i; j < right.Length; j++)
                {
                    odds[j] = -right[j];
                }
            }

            return new Polynomial(odds);
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

            int[] odds = new int[left.Length*right.Length];
            int k = 0;
            for(int i = 0; i < left.Length; i++)
            {
                for(int j = 0; j < right.Length; j++)
                {
                    odds[k] = left[i] * right[j];
                    k++;
                }
            }

            return new Polynomial(odds);
        }

        public static Polynomial operator *(Polynomial polynomial, int value)
        {
            if (polynomial == null)
            {
                throw new ArgumentNullException(string.Format("Polynomial {0} is null", polynomial));
            }

            int[] odds = new int[polynomial.Length];
            for(int i = 0; i < polynomial.Length; i++)
            {
                odds[i] = polynomial[i] * value;
            }

            return new Polynomial(odds);
        }

        public static Polynomial operator *(int value, Polynomial polynomial)
        {
            if (polynomial == null)
            {
                throw new ArgumentNullException(string.Format("Polynomial {0} is null", polynomial));
            }

            int[] odds = new int[polynomial.Length];
            for (int i = 0; i < polynomial.Length; i++)
            {
                odds[i] = polynomial[i] * value;
            }

            return new Polynomial(odds);
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

        public string ToStringSignificant()
        {
            string stringRepresentation = "";
            string formatString = "";

            for (int i = Length-1; i > 0; i--)
            {
                if (this[i] != 0 && i != 1)
                {
                    formatString = i == (Length - 1) ? "{0:0; - 0}X^{1}" : "{0: + 0; - 0}X^{1}";
                    stringRepresentation += string.Format(formatString, this[i], i);
                }
                else if(this[i] != 0)
                {
                    formatString = i == (Length - 1) ? "{0:0; - 0}X" : "{0: + 0; - 0}X";
                    stringRepresentation += string.Format(formatString, this[i]);
                }
                
            }

            return stringRepresentation;
        }
    }
}
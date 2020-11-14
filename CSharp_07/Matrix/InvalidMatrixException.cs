using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MatrixTask
{
    [Serializable]
    public class InvalidMatrixException : Exception
    {
        private int rightRowsCount;
        private int rightColumnsCount;
        private int leftRowsCount;
        private int leftColumnsCount;

        public int RightColumnsCount
        {
            get
            {
                return rightColumnsCount;
            }
            set
            {
                rightColumnsCount = value;
            }
        }

        public int RightRowsCount
        {
            get
            {
                return rightRowsCount;
            }
            set
            {
                rightRowsCount = value;
            }
        }

        public int LeftRowsCount
        {
            get
            {
                return leftRowsCount;
            }
            set
            {
                leftRowsCount = value;
            }
        }

        public int LeftColumnsCount
        {
            get
            {
                return leftColumnsCount;
            }
            set
            {
                leftColumnsCount = value;
            }
        }
        public InvalidMatrixException()
        {

        }

        public InvalidMatrixException(Matrix leftMatrix, Matrix rightMatrix, string message) : base(message)
        {
            LeftRowsCount = leftMatrix.RowsCount;
            LeftColumnsCount = leftMatrix.ColumnsCount;
            RightRowsCount = rightMatrix.RowsCount;
            RightColumnsCount = rightMatrix.ColumnsCount;
        }

        public InvalidMatrixException(string message) : base(message)
        {
            
        }

        public InvalidMatrixException(string message, Exception innerException) : base(message, innerException)
        {

        }

        protected InvalidMatrixException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            if (info != null)
            {
                this.RightRowsCount = info.GetInt32("RightRowsCount");
                this.RightColumnsCount = info.GetInt32("RightColumnsCount");
                this.LeftRowsCount = info.GetInt32("LeftRowsCount");
                this.LeftColumnsCount = info.GetInt32("LeftColumnsCount");
            }
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("RightRowsCount", this.RightRowsCount);
            info.AddValue("RightColumnsCount", this.RightColumnsCount);
            info.AddValue("LeftRowsCount", this.LeftRowsCount);
            info.AddValue("LeftColumnsCount", this.LeftColumnsCount);
        }
    }
}

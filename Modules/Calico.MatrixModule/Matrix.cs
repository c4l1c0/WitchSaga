using System.Numerics;

namespace Calico.MatrixModule;

public class Matrix
{
    private BigInteger[,] _data;

    public uint RowSize { get; init; }
    public uint ColumnSize { get; init; }

    public Matrix(uint rowSize, uint columnSize)
    {
        RowSize = rowSize;
        ColumnSize = columnSize;
        _data = new BigInteger[rowSize, columnSize];
    }
    
    public BigInteger this[uint row, uint column]
    {
        get
        {
            ValidateIndex(row, column);
            return _data[row, column];
        }
        set
        {
            ValidateIndex(row, column);
            _data[row, column] = value;
        }
    }
    
    public Matrix Multiply(Matrix matrixToMultiply)
    {
        if (ColumnSize != matrixToMultiply.RowSize)
            throw new ArgumentException("Matrix can't be multiplied. Invalid dimension.");

        var result = new Matrix(RowSize, matrixToMultiply.ColumnSize);
        for (uint i = 0; i < RowSize; i++)
        {
            for (uint j = 0; j < matrixToMultiply.ColumnSize; j++)
            {
                for (uint k = 0; k < ColumnSize; k++)
                {
                    result[i, j] += this[i, k] * matrixToMultiply[k, j];
                }
            }
        }

        return result;
    }

    public Matrix Power(uint exponent)
    {
        if (RowSize != ColumnSize)
            throw new InvalidOperationException("Exponent can only be used on square matrices.");

        if (exponent == 0)
        {
            return Identity(RowSize);
        }
        if (exponent == 1)
        {
            return this;
        }

        var halfExponent = Power(exponent / 2);
        var result = halfExponent.Multiply(halfExponent);

        if (exponent % 2 == 1)
        {
            result = result.Multiply(this);
        }

        return result;
    }
    
    public static Matrix Identity(uint size)
    {
        var identity = new Matrix(size, size);
        for (uint i = 0; i < size; i++)
        {
            identity[i, i] = 1;
        }

        return identity;
    }

    private void ValidateIndex(uint row, uint column)
    {
        if (row >= RowSize) 
        {
            throw new IndexOutOfRangeException($"Row {row} is out of range");
        }

        if (column >= ColumnSize)
        {
            throw new IndexOutOfRangeException($"Column {column} is out of range.");
        }
    }
}

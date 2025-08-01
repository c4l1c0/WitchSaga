using System.Numerics;

namespace Calico.MatrixModule;

public interface IMatrix
{
    uint RowSize { get; init; }
    uint ColumnSize { get; init; }
    
    BigInteger this[uint row, uint column] { get; set; }

    Matrix Multiply(Matrix matrixToMultiply);
    Matrix Power(uint exponent);
}

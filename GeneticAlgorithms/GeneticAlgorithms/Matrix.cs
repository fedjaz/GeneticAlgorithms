﻿using System;
using Newtonsoft.Json;


namespace GeneticAlgorithms
{
    public class Matrix<T> : ICloneable
    {
        [JsonProperty]
        T[,] arr;
        public int Rows { get; set; }
        public int Cells { get; set;  }
        public delegate T FillMethod();

        public Matrix()
        {
        }

        public Matrix(int rows, int cells)
        {
            Rows = rows;
            Cells = cells;
            arr = new T[rows, cells];
        }

        public Matrix(int rows, int cells, FillMethod method)
        {
            Rows = rows;
            Cells = cells;
            arr = new T[rows, cells];
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cells; j++)
                {
                    arr[i, j] = method.Invoke();
                }
            }
        }

        public Matrix(T[,] arr)
        {
            this.arr = arr;
            Rows = arr.GetLength(0);
            Cells = arr.GetLength(1);
        }

        public T this[int i, int j]
        {
            get => arr[i, j];
            set => arr[i, j] = value;
        }

        public static Matrix<T> operator * (Matrix<T> m1, Matrix<T> m2)
        {
            if(m1.Cells != m2.Rows)
            {
                throw new InvalidOperationException("Sizes of matrices doen't match.");
            }
            Matrix<T> m3 = new Matrix<T>(m1.Rows, m2.Cells);

            for (int i = 0; i < m1.Rows; i++)
            {
                for(int k = 0; k < m2.Cells; k++)
                {
                    for (int j = 0; j < m1.Cells; j++)
                    {
                        dynamic a = m1[i, j];
                        dynamic b = m2[j, k];
                        try
                        {
                            m3[i, k] += a * b;
                        }
                        catch
                        {
                            throw new InvalidOperationException($"Matricec of {typeof(T)} canno't be multiplied.");
                        }
                    }
                }
            }
            return m3;
        }

        public static Matrix<T> operator + (Matrix<T> m1, Matrix<T> m2)
        {
            if(m1.Rows != m2.Rows || m1.Cells != m2.Cells)
            {
                throw new InvalidOperationException("Sizes of matrices doen't match.");
            }
            Matrix<T> m3 = new Matrix<T>(m1.Rows, m2.Cells);
            for(int i = 0; i < m1.Rows; i++)
            {
                for(int j = 0; j < m1.Cells; j++)
                {
                    dynamic a = m1[i, j];
                    dynamic b = m2[i, j];
                    try
                    {
                        m3[i, j] = a + b;
                    }
                    catch
                    {
                        throw new InvalidOperationException($"Matricec of {typeof(T)} canno't be added.");
                    }
                }
            }
            return m3;
        }  

        public object Clone()
        {
            T[,] arr = new T[Rows, Cells];
            for(int i = 0; i < Rows; i++)
            {
                for(int j = 0; j < Cells; j++)
                {
                    arr[i, j] = this.arr[i, j];
                }
            }
            return new Matrix<T>(arr);
        }
    }
}

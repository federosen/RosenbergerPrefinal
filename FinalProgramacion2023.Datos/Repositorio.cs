using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProgramacion2023.Entidades;

namespace FinalProgramacion2023.Datos
{
    public class Repositorio
    {
            private readonly string _archivo = Environment.CurrentDirectory + "\\Cuadrilateros.txt";
            private readonly string _archivoBak = Environment.CurrentDirectory + @"\\Cuadrilateros.bak";


            private List<Cuadrilateros> listaCuadrilateros = new List<Cuadrilateros>();

            public Repositorio()
            {
                listaCuadrilateros = new List<Cuadrilateros>();
                listaCuadrilateros = LeerDatosDelArchivo();
            }

            private List<Cuadrilateros> LeerDatosDelArchivo()
            {
                var lista = new List<Cuadrilateros>();
                if (File.Exists(_archivo))
                {
                    StreamReader lector = new StreamReader(_archivo);
                    while (!lector.EndOfStream)
                    {
                        var linea = lector.ReadLine();
                        Cuadrilateros cuadrilateros = ConstruirCuadrilatero(linea);
                        lista.Add(cuadrilateros);
                    }
                    lector.Close();
                }
                return lista;
            }


            private Cuadrilateros ConstruirCuadrilatero(string linea)
            {
                var campos = linea.Split(';');
                return new Cuadrilateros()
                {
                    ladoA = int.Parse(campos[0]),
                    ladoB = int.Parse(campos[1]),
                    Relleno = int.Parse(campos[2]),
                };
            }



            private void AgregarEnArchivo(Cuadrilateros cuadrilateros)
            {
                StreamWriter escritor = new StreamWriter(_archivo, true);
                var linea = ConstruirLinea(cuadrilateros);
                escritor.WriteLine(linea);
                escritor.Close();
            }



            public void Agregar(Cuadrilateros cuadrilateros)
            {
                listaCuadrilateros.Add(cuadrilateros);
                AgregarEnArchivo(cuadrilateros);
            }


            private string ConstruirLinea(Cuadrilateros cuadrilateros)
            {
                return $"{cuadrilateros.ladoA} ; {cuadrilateros.ladoB} ; {cuadrilateros.Relleno}";
            }


            public void Borrar(Cuadrilateros cuadrilateros)
            {
                listaCuadrilateros.Remove(cuadrilateros);
            }


            public int GetCantidad()
            {
                return listaCuadrilateros.Count();
            }


            public List<Cuadrilateros> GetList()
            {
                return listaCuadrilateros;
            }


            public Cuadrilateros GetPorPosicion(int index)
            {
                return listaCuadrilateros[index];
            }


            public bool Existe(Cuadrilateros cuadrilateros)
            {
                return listaCuadrilateros.Contains(cuadrilateros);
            }


            public void Editar(Cuadrilateros cuadrilaterosSeleccionado, Cuadrilateros cuadrilaterosEditado)
            {
                var index = listaCuadrilateros.FindIndex(r =>
                    r.ladoA == cuadrilaterosSeleccionado.ladoA &&
                    r.ladoB == cuadrilaterosSeleccionado.ladoB);
                listaCuadrilateros.RemoveAt(index);
                listaCuadrilateros.Insert(index, cuadrilaterosEditado);
                EditarRegistroEnArchivo(cuadrilaterosSeleccionado, cuadrilaterosEditado);
            }

            private void EditarRegistroEnArchivo(Cuadrilateros cuadrilaterosSeleccionado, Cuadrilateros cuadrilaterosEditado)
            {
                StreamReader lector = new StreamReader(_archivo);
                StreamWriter escritor = new StreamWriter(_archivoBak);
                while (!lector.EndOfStream)
                {
                    var linea = lector.ReadLine();
                    Cuadrilateros cuadrilaterosEnArchivo = ConstruirCuadrilatero(linea);
                    if (!cuadrilaterosEnArchivo.Equals(cuadrilaterosSeleccionado))
                    {
                        escritor.WriteLine(linea);
                    }
                    else
                    {
                        linea = ConstruirLinea(cuadrilaterosEditado);
                        escritor.WriteLine(linea);
                    }
                }
                escritor.Close();
                lector.Close();
                File.Delete(_archivo);
                File.Move(_archivoBak, _archivo);
            }
        }
    }


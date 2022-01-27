using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace P17SerializacionBinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            string valor = "";

            Console.WriteLine("1) creat y serializar auto" +
                "2) leer auto");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);
            if(opcion == 1)
            {
                //creamos el objeto CAuto
                string modelo = "";
                double costo = 0;

                Console.WriteLine("Dame el modelo");
                modelo = Console.ReadLine();

                Console.WriteLine("Dame el costo");
                valor = Console.ReadLine();
                costo = Convert.ToDouble(valor);

                CAuto cAuto = new CAuto(modelo, costo);

                Console.WriteLine("Auto a serializar");
                cAuto.MuestraInformacion();

                //Empezamos la serializacion
                Console.WriteLine("----Serializando----");
                
                //Seleccionamos el formateador
                BinaryFormatter formateador = new BinaryFormatter();

                //Se crea el stream
                Stream stream = new FileStream("Autos.aut", 
                    FileMode.Create, FileAccess.Write, FileShare.None);

                //Serializamos
                formateador.Serialize(stream, cAuto);

                //Cerramos el stream
                stream.Close();
            }
            if(opcion == 2)
            {
                //Deserializamos el objetos
                Console.WriteLine("---Deserializando---");

                //Seleccionamos el formateador
                BinaryFormatter formatter = new BinaryFormatter();

                //Creamos le stream
                Stream stream = new FileStream("Autos.aut",
                    FileMode.Open, FileAccess.Read, FileShare.None);

                //Deserializamos
                CAuto cAuto = (CAuto)formatter.Deserialize(stream);

                //cerramos le stream
                stream.Close();

                //Usamos el objeto
                Console.WriteLine("El auto deserializado es");
                cAuto.MuestraInformacion();
            }
        }
    }
}

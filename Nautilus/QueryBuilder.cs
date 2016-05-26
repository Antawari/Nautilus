using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nautilus
{
    public class QueryBuilder
    {
        //Declaracion de variables necesarias para la concatenacion y el resultado
        private static string constructor;
        private static string constructorLoop;
        private static string constructorWhere;
        private static string resultado;
        private static int counter;

        //Constructor de sentencias SQL para el caso DELETE
        public static string DeleteSQL(string table, string condicional)
        {

            constructor = "DELETE FROM " + table + " WHERE " + condicional + ";";
            resultado = constructor;

            return resultado;
        }





        //Constructor de sentencias SQL para el caso de UPDATE.
        public static string UpdateSQL(string _table, string[,,] _values, string[,,] _where)
        {

            //comenzamos el constructor
            constructor = "UPDATE " + _table + " SET ";

            //Iniciamos el loop para ell llenado de todos los campos a actualizar.
            //requerimos la longitud de la matriz values
            int longitud = _values.GetLength(0);
            counter = 0;
            while (counter < longitud)
            {
                string value1 = _values[counter, 0, 0];
                string value2 = _values[counter, 0, 1];
                string tipo = _values[counter, 0, 2];

                //Condicional que añade o quita el apostrofe del valor

                if (tipo == "string")
                {
                    //colocamos apostrofes en el valor
                    constructorLoop = constructorLoop + " " + value1 + "='" + value2 + "',";
                }
                else
                {
                    //Quitamos los apostrofes del valor
                    constructorLoop = constructorLoop + value1 + "=" + value2 + ",";
                }
                counter++;
            }

            //Eliminar la ultima coma del constructorLoop
            constructorLoop = constructorLoop.Remove(constructorLoop.Length - 1); //Solo elimina la ultima coma


            //Seguimos con el constructor, agregamos el ciclo obtenido.
            constructor = constructor + constructorLoop;
            //fin del ciclo de construccion
            //Asignacion de la condicional en la sentencia SQL
            string campo = _where[0, 0, 0];
            string valor = _where[0, 0, 1];
            string tipoCondicional = _where[0, 0, 2];
            //Agregamos los apostrofes en caso string
            if (tipoCondicional == "string")
            {
                constructorWhere = @" WHERE " + campo + "='" + valor + "';";
            }
            else
            {
                constructorWhere = @" WHERE " + campo + "=" + valor + ";";
            }

            //Concatenacion completa
            resultado = constructor + constructorWhere;

            return resultado;

        }


    }
}

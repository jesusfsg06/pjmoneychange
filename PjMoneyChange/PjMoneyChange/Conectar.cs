using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace PjMoneyChange
{
    
    class Conectar
    {


         public static string tipo;

            SqlConnection cn = new SqlConnection(@"Data Source=SOFOCANDO\SOFOCANDO; Initial Catalog=DBMoneyChange; Integrated Security = true;");
       /*     public static string usuario;
            public static string clave;
            public static string sexo;
            public static string fecha;
            public static string direccion;
            public static string nombre;
            public static string telefono;/*/


            public static string empresasocial;
            public static string empresanombre;
            public static string empleadonombre;
            public static string empleadouser;

    }

}
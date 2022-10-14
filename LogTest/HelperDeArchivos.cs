public static class HelperDeArchivos{
    
    public static void crearCSV(string ruta, string curso){
    
        if(Directory.Exists(ruta)){
            FileStream fileStream;

            if(!File.Exists(ruta + @$"\{curso}.csv")){
                Console.WriteLine("Creando archivo csv...");
                fileStream = File.Create(ruta + @$"\{curso}.csv");
                fileStream.Close();
            }

            var archivo = new FileStream(ruta + @$"\{curso}.csv", FileMode.Truncate);
            string cadena = "ID;NOMBRE;APELLIDO;DNI\n";

            StreamWriter escribir = new StreamWriter(archivo);
            escribir.Write(cadena);
            escribir.Close();
            archivo.Close();
            
        }
        else{
            Console.WriteLine("La ruta ingresada no existe");
        }
    }

    public static void escribir_contenido(string ruta, string curso, Alumno a){
        if(File.Exists(ruta + @$"\{curso}.csv")){
            StreamWriter file = new StreamWriter(ruta + @$"\{curso}.csv", true);

            file.WriteLine($"{a.Id};{a.Nombre};{a.Apellido};{a.Dni}");

            file.Close();   
        }
    }

    public static void leerCSV(string ruta, string curso){
        if(File.Exists(ruta + @$"\{curso}.csv")){
            StreamReader file = new StreamReader(ruta + @$"\{curso}.csv");
            string line = "";
            //Lee linea por linea hasta que termina el archivo
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            file.Close();   
        }
    }
    
    public static void limpiar_contenido(string ruta, string curso){
        if (Path.GetFileName(ruta + @$"\{curso}.csv").Split('.')[1] == "csv") File.Delete(ruta + @$"\{curso}.csv");
    }
}
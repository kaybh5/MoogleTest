using System;

public class LoadTxt
{
    public string Direccion { get; set; }
    public string[] AllFilesPaths { get; set; }
    public string[] TxtFilesPaths { get; set; }



    public LoadTxt(string direccion)
    { // metodo para cargar los txt :), constructor 
        Direccion = direccion;  //Esto almacena la direccion de la carpeta donde estan los archivos ejemplo: kayla/moogle/content
        AllFilesPaths = Directory.GetFiles(this.Direccion); //esta variable contiene todas las direcciones de los archivos de la carpeta
        TxtFilesPaths = new string[AllFilesPaths.Length]; // contiene solamente las direcciones de los archivos que terminen en .txt
    }

    public string[] CleanPaths()
    { // esta funcion va a almacenar en un nuevo array (this.TxtFilesPaths) las direcciones de archivos txt
        for (int i = 0; i < AllFilesPaths.Length; i++)
        {
            if (this.AllFilesPaths[i].Contains(".txt"))
            {
                this.TxtFilesPaths[i] = this.AllFilesPaths[i];
            }
        }
        return this.TxtFilesPaths;
    }
    public string[] AllWords() // daniel como puedo probar si esta poronga funciona ?? 
    {

        HashSet<string> unrepeatedWords = new HashSet<string>();
        StreamReader reader = new StreamReader("/Users/mariasilvia/Documents/Moogle/MoogleTest/content");
        string text = reader.ReadToEnd();
        reader.Close();

        while (true)
        {
            
        }

        string[] words = text.Split(new char[] { ' ', 'n', 'r', 't' }, StringSplitOptions.RemoveEmptyEntries);
        //  para separar el contenido del archivo de texto en palabras y almacenándolas en un array llamado "words"

        return words;


    }


}





class Program // para probar 
{


    static void Main()
    {
        LoadTxt Objeto1 = new LoadTxt("/Users/mariasilvia/Documents/Moogle/MoogleTest/content");
        Objeto1.CleanPaths();

        //System.Console.WriteLine(string.Join("\n ", Objeto1.Direcciones));
    }


}

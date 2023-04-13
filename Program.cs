using System;

public class LoadTxt
{
    public string Direccion { get; set; }
    public string[] AllFilesPaths { get; set; }
    public string[] TxtFilesPaths { get; set; }
    public string[] Texts { get; set; }


    public LoadTxt(string direccion)
    { // metodo para cargar los txt :), constructor 
        Direccion = direccion;  //Esto almacena la direccion de la carpeta donde estan los archivos ejemplo: kayla/moogle/content
        AllFilesPaths = Directory.GetFiles(this.Direccion); //esta variable contiene todas las direcciones de los archivos de la carpeta
        TxtFilesPaths = new string[AllFilesPaths.Length]; // contiene solamente las direcciones de los archivos que terminen en .txt
        Texts = new string[AllFilesPaths.Length];
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

    public string[] GetTextosFromTXT(){
        for (int i = 0; i < this.TxtFilesPaths.Length; i++)
        {
            if (this.TxtFilesPaths[i] != null)
            {
                Texts[i] = File.ReadAllText(this.TxtFilesPaths[i]);
            }
        }
        System.Console.WriteLine(string.Join(", ", this.Texts));
        return this.Texts;
    }




}

class Program // para probar 
{
    static void Main()
    {
        LoadTxt Objeto1 = new LoadTxt("/Users/mariasilvia/Documents/Moogle/MoogleTest/content");
        Objeto1.CleanPaths();
        Objeto1.GetTextosFromTXT();

        //System.Console.WriteLine(string.Join("\n ", Objeto1.Direcciones));
    }
}

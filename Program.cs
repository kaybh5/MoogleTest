using System;

public class LoadTxt
{
    public string Direccion { get; set; }
    public string[] AllFilesPaths { get; set; }
    public string[] TxtFilesPaths { get; set; }
    public string[] Texts { get; set; }
    public string[] Words { get; set; }

     public string[] UnrepeatedWords {get ; set; }


    public LoadTxt(string direccion)  //constructor
    { // metodo para cargar los txt :),  
        Direccion = direccion;  //Esto almacena la direccion de la carpeta donde estan los archivos ejemplo: kayla/moogle/content
        AllFilesPaths = Directory.GetFiles(this.Direccion); //esta variable contiene todas las direcciones de los archivos de la carpeta
        TxtFilesPaths = new string[AllFilesPaths.Length]; // contiene solamente las direcciones de los archivos que terminen en .txt
        Texts = new string[AllFilesPaths.Length];
        string[] Word;
        string [] UnrepeatedWords ; 

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

    public string[] GetTextosFromTXT()  //Devuelve los textos que estan en los txt
    {
        for (int i = 0; i < this.TxtFilesPaths.Length; i++)
        {
            if (this.TxtFilesPaths[i] != null)
            {
                this.Texts[i] = File.ReadAllText(this.TxtFilesPaths[i]);
                this.Texts[i] = this.Texts[i].ToLower();
            }
        }
        // System.Console.WriteLine(string.Join(", ", this.Texts));
        return this.Texts;
    }

    public string[] SepararPalabras()   //Separa los textos en palabras
    {
        string VariableQueContieneTodosLosTexos = "";
        for (int i = 0; i < this.Texts.Length; i++)
        {
            VariableQueContieneTodosLosTexos += this.Texts[i];
        }
        char[] delimeters = new char[] { ' ', '.', ',', ';', ':', '!', '?', };
        Words = VariableQueContieneTodosLosTexos.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);

        System.Console.WriteLine(string.Join(", ", Words));


        return this.Words;



    }

        public  String[] CleanWords()
        {       //para quitar las palabras repetidas de los txt
            this.UnrepeatedWords = Words.Distinct().ToArray();
            return this.UnrepeatedWords;
        }
}


class Program // para probar 
{


    
    static void Main()
    {
        LoadTxt Objeto1 = new LoadTxt("/Users/mariasilvia/Documents/Moogle/MoogleTest/content");
        Objeto1.CleanPaths();
        Objeto1.GetTextosFromTXT();
        Objeto1.SepararPalabras();
        Objeto1.CleanWords(); 


        //System.Console.WriteLine(string.Join("\n ", Objeto1.Direcciones));
    }
}

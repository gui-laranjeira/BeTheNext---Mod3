using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;


namespace Poo2_Ex5_DIctionary
{
    public class Dicionario
    {

        private Dictionary<string, string> _dic;
        private string _enderecoArquivo;

        public Dicionario(string enderecoArquivo)
        {
            _dic = new Dictionary<string, string>();
            _enderecoArquivo = enderecoArquivo;
            CreateJsonFile();
            LoadData();
        }


        public void AddTermo(string termo, string definition) 
        {
            termo = termo.ToLower();

            if (_dic.ContainsKey(termo))
            {
                Console.WriteLine("Esse termo já existe no dicionário!");
            }
            else
            {
                _dic.Add(termo, definition);
                SaveData();
                Console.WriteLine($"\nTermo '{termo}' adicionado ao dicionário!");
                Console.ReadLine();
            }
        }

        public void ProcurarTermo(string procurarTermo)
        {
            Console.Clear();

            procurarTermo= procurarTermo.ToLower();

            Dictionary<string, string> termosEncontrados = new();

            foreach(KeyValuePair<string, string> kvp in _dic)
            {
                if (kvp.Key.Contains(procurarTermo))
                {
                    termosEncontrados.Add(kvp.Key, kvp.Value);                    
                }
            }

            if (termosEncontrados.Count == 0)
            {
                Console.WriteLine("Nenhum termo encontrado.");
            }
            else
            {
                Console.WriteLine("Termos encontrados: \n");
                foreach (KeyValuePair<string, string> kvp in termosEncontrados)
                {
                    Console.WriteLine(kvp.Key + " = " + kvp.Value);                  
                    
                }
            }
        }

        private void SaveData()
        {
            using (FileStream fs = new FileStream(_enderecoArquivo, FileMode.Create))
            {
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Dictionary<string, string>));
                jsonSerializer.WriteObject(fs, _dic);
            }
        }

        private void LoadData()
        {
            if(File.Exists(_enderecoArquivo))
            {
                using(FileStream fs = new FileStream(_enderecoArquivo, FileMode.Open))
                {
                    DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Dictionary<string, string>));
                    _dic = (Dictionary<string, string>)jsonSerializer.ReadObject(fs);
                }
            }
        }

        private void CreateJsonFile()
        {
            if (!File.Exists(_enderecoArquivo))
            {
                using (FileStream fs = File.Create(_enderecoArquivo)) ;
            }
        }
    }
}

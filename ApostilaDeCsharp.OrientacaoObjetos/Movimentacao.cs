using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostilaDeCsharp.OrientacaoObjetos
{
    public class Movimentacao
    {
        public string Voar(Personagem p)
        {
            if (p.QtdePontos > 10)
            {
                return $"{p.Nome} voou";
            }
            else
            {
                return $"{p.Nome} não voou";
            }
        }

        public void Nadar(Personagem p)
        {

        }

        public void Pular(Personagem p)
        {

        }
        
        public void Correr(Personagem p)
        {

        }

        public void VirarEsquerda(Personagem p)
        {

        }

        public void VirarDireita(Personagem p)
        {

        }

        public void Parar(Personagem p)
        {

        }

        public void Andar(Personagem p)
        {

        }

        public void Voltar(Personagem p)
        {

        }
    }
}

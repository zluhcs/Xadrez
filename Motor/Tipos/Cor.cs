﻿using System;

namespace Enxadrista
{
    /// <summary>
    /// Representa as cores do tabuleiro.
    /// </summary>
    [Flags]
    public enum Cor : sbyte
    {
        Branca = 0,
        Preta = 1,
        Nenhuma = 2
    }
    
    /// <summary>
    /// Classe auxiliar com funções de cores.
    /// </summary>
    public static class CorExtensao
    {
        /// <summary>
        /// Troca a cor.
        /// </summary>
        public static Cor Invertida(this Cor cor)
        {
            return cor ^ Cor.Preta;
        }
        
        /// <summary>
        /// Converte uma cor para texto que a representa.
        /// Branca -> "w" (white)
        /// Preta -> "b" (black)
        /// Nenhuma -> "-" (não definido)
        /// </summary>
        public static string ParaTexto(this Cor cor)
        {
            var representacoes = new[] {"w", "b", "-"};
            return representacoes[(int)cor];
        }
        
        /// <summary>
        /// Converte um texto para uma cor.
        /// "w" (white) -> Branca
        /// "b" (black) -> Preta
        /// </summary>
        public static Cor ParaCor(this string cor)
        {
            switch (cor)
            {
                case "w": return Cor.Branca;
                case "b": return Cor.Preta;
                default: return Cor.Nenhuma;
            }
        }
        
        /// <summary>
        /// Converte a cor para multiplicador de pontos.
        /// "w" (white) -> 1
        /// "b" (black) -> -1
        /// </summary>
        public static int Multiplicador(this Cor cor)
        {
            return (int)cor * -2 + 1;
        }
    }
}
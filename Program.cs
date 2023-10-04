// See https://aka.ms/new-console-template for more information
using Laboratorio;
using Laboratorio.Algoritmos;
using Laboratorio.ClassesDeExemplo;
using Laboratorio.DesignPattern;
using Laboratorio.Fundamentos;

var central = new CentralLab(new Dictionary<string, Action>() {
                {"Binary Search - Algoritmos", BinarySearch.Executar},
                {"Igualdades - Fundamentos", igualdades.Executar},
                {"UpCast e DownCast - Fundamentos", UpCastingEDownCasting.Executar},
                {"Avatar - Fundamentos", Avatar.Executar},
                {"Arrays Privados - Fundamentos", ArraysPrivadosTeste.Executar},
                {"Factory - Design Pattern", Factory.Executar},
            });

central.SelecionarEExecutar();
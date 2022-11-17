//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }
        //El metodo devuelve como texto la receta, para que otra clase la pueda imprimir. 
        //Se utiliza el patrón SRP, ya que cada clase tiene una responsabilidad sobre una parte de la funcionalidad del software
        //      y esa responsabilidad, en este caso imprimir la receta, está completamente encapsulada por la clase ConsolePrinter.
        public string GetRecipeText()
        {
           List<string> text = new List<string>();
           foreach (Step step in this.steps)
           {
            text.Add($"{step.Quantity} de '{step.Input.Description}' usando '{step.Equipment.Description}' durante {step.Time}");
           } 
           return string.Join( "\n", text);
        }
    }
}
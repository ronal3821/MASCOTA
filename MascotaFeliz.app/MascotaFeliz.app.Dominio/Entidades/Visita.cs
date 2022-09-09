using System;

namespace MascotaFeliz.app.dominio

{
    public class Visita

    {
              
        public char fechaVisita {get; set;}
        public char motivoVisita {get; set;}
        public float peso {get; set;}
        public float talla {get; set;}
        public float temperatura {get; set;}
        public string? recomendaciones {get; set;}
        public Mascota? Mascota {get; set;}
        public Veterinario? Veterinario {get; set;}

    }


}
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InterfaceUser
{
    using System;
    using System.Collections.Generic;
    
    public partial class temoignage
    {
        public int id { get; set; }
        public int personne_login { get; set; }
        public string contenu { get; set; }
        public System.DateTime date { get; set; }
        public short valide { get; set; }
    
        public virtual personne_login personne_login1 { get; set; }
    }
}

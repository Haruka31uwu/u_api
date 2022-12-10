using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using u_api.Modelos;

namespace u_api.Repositories
{
    public class RPInstitutos
    {
        public static List<Instituto> _listaInstitutos = new List<Instituto>()
        {
            new Instituto(){nombre="Tecsup"},
            new Instituto(){nombre="Idat"},
            new Instituto(){nombre="Cibertec"},
            new Instituto(){nombre="Iberoamericana"},
            new Instituto(){nombre="Instituto Peruano De Administración De Empresas Ipae"},
            new Instituto(){nombre="Toulouse Lautrec"},
            new Instituto(){nombre="Alexander Von Humboldt"},
            new Instituto(){nombre="San Ignacio De Loyola S.A. - Isil "},
            new Instituto(){nombre="Nuestra Señora Del Carmen "},
            new Instituto(){nombre="Instituto Peruano De Publicidad"},
            new Instituto(){nombre="Steve Jobs"},
            new Instituto(){nombre="Khipu"},
            new Instituto(){nombre="Peruano De Sistemas Sise"},
            new Instituto(){nombre="San Antonio"},
            new Instituto(){nombre="Centro Peruano De Estudios Bancarios - Cepeban"},
            new Instituto(){nombre="Instituto Técnico De Administración De Empresas -Itae"},
            new Instituto(){nombre="Inlog"},
            new Instituto(){nombre="De Comercio Exterior"},
            new Instituto(){nombre="Cetemin"},
            new Instituto(){nombre="Le Cordon Bleu Perú"},
            new Instituto(){nombre="Peruano De Marketing"},
            new Instituto(){nombre="San Lucas"},
            new Instituto(){nombre="Certus"},
            new Instituto(){nombre="Charles Chaplin"},
            new Instituto(){nombre="Lima Institute Of Technical Studies-Lits"},
            new Instituto(){nombre="El Buen Pastor"},
            new Instituto(){nombre="Paul Müller"},
            new Instituto(){nombre="Daniel  Alcides Carrión"},
            new Instituto(){nombre="San José Del Sur "},
            new Instituto(){nombre="Bsg Institute"},
            new Instituto(){nombre="Santa Rosa De Lima"},
            new Instituto(){nombre="Corazón De Jesús"},
            new Instituto(){nombre="Wernher Von Braun"},
            new Instituto(){nombre="Columbia"},
            new Instituto(){nombre="Nina Design"},
            new Instituto(){nombre="La Pontificia"},
            new Instituto(){nombre="Alas Peruanas"},
            new Instituto(){nombre="Orson Welles"},
            new Instituto(){nombre="Instituto De Educación Superior Privado San Ignacio De Monterrico-Sidem"},
            new Instituto(){nombre="Fibonacci"},
            new Instituto(){nombre="Chio Lecca"},
            new Instituto(){nombre="Condoray"},
            new Instituto(){nombre="Continental"},
            new Instituto(){nombre="Instituto Peruano De Arte Y Diseño"},
            new Instituto(){nombre="De Emprendedores"},
            new Instituto(){nombre="Ansimar"},
            new Instituto(){nombre="Alta Cocina D´Gallia"},
            new Instituto(){nombre="Interamericano"},
            new Instituto(){nombre="Centro De Altos Estudios De La Moda Ceam"},
            new Instituto(){nombre="Centro De La Imagen"},
            new Instituto(){nombre="Idatur"},
            new Instituto(){nombre="De Investigaciòn Socioeconòmico Latinoamericano Intur Perù"},
            new Instituto(){nombre="Arzobispo Loayza"},
            new Instituto(){nombre="San Marcos"},
            new Instituto(){nombre="Ricardo Palma"},
            new Instituto(){nombre="Juan Bosco De Huanuco"},
            new Instituto(){nombre="Daniel  Alcides Carrión"},
            new Instituto(){nombre="Juan Bosco De Huanuco"},
            new Instituto(){nombre="Jose Carlos Mariategui"},
            new Instituto(){nombre="Elmer Faucett"},
            new Instituto(){nombre="Administraciòn Y Negocios"},
            new Instituto(){nombre="Repùblica Federal De Alemania"},
            new Instituto(){nombre="Huando"},
            new Instituto(){nombre="Clorinda Matto De Turner"},
            new Instituto(){nombre="Francisco De Paula Gonzales Vigil"},
            new Instituto(){nombre="Sabio Nacional Antunez De Mayolo - Telesup"},
            new Instituto(){nombre="Federico Villarreal"},
            new Instituto(){nombre="Ceturgh Perú"},
            new Instituto(){nombre="Simón Bolívar"},
            new Instituto(){nombre="Nuevo Pachacutec"},
            new Instituto(){nombre="Instituto De Profesiones Empresariales Inteci"},
            new Instituto(){nombre="Sergio Bernales"},
            new Instituto(){nombre="María Montessori"},
            new Instituto(){nombre="Cepea"},
            new Instituto(){nombre="Ef"},
            new Instituto(){nombre="Tec"},
            new Instituto(){nombre="Ilc"},
            new Instituto(){nombre="Corriente Alterna"},
            new Instituto(){nombre="Educación Médica San Fernando"},
            new Instituto(){nombre="De Optometría Y Ciencias Eurohispano"},
            new Instituto(){nombre="Santa María"},
            new Instituto(){nombre="Instituto Peruano De Administracion De Empresas - Ipae Iquitos"},
            new Instituto(){nombre="Complejo Hospitalario San Pablo"},
            new Instituto(){nombre="Lilia Gutierrez Molero"},
            new Instituto(){nombre="Mod´Art Peru"},
            new Instituto(){nombre="Latino Barranca"},
            new Instituto(){nombre="Investigacion, Ciencia Y Tecnología"},
            new Instituto(){nombre="Maria Elena Moyano"},
            new Instituto(){nombre="Cesde"},
            new Instituto(){nombre="Nuestra Señora De Montserrat"}
        };
        public IEnumerable<Instituto> getInstitutos()
        {
            return _listaInstitutos;
        }public Instituto getInstituto(string nombre)
        {
            var inst = _listaInstitutos.Where(ins => ins.nombre == nombre);
            return inst.FirstOrDefault();
        }
}
}

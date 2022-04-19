using Microsoft.EntityFrameworkCore;
using QuestionGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionGame.DataSeeding
{
    public class SeedData : ISeedData
    {
        public void AddCategoryData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                        new Category { Id = 1, Name = "Deportes", LevelId = 1 },
                        new Category { Id = 2, Name = "Matematicas", LevelId = 2 },
                        new Category { Id = 3, Name = "Cultura", LevelId = 3 },
                        new Category { Id = 4, Name = "Anime", LevelId = 4 },
                        new Category { Id = 5, Name = "Ciencia", LevelId = 5 }
                        );
        }

        public void AddLevelData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Level>().HasData(
                new Level { Id = 1, Difficulty = 1, Points = 100 },
                new Level { Id = 2, Difficulty = 2, Points = 200 },
                new Level { Id = 3, Difficulty = 3, Points = 300 },
                new Level { Id = 4, Difficulty = 4, Points = 400 },
                new Level { Id = 5, Difficulty = 5, Points = 500 }
                );
        }

        public void AddOptionsData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Option>().HasData(
                  new Option { Id = 1, Description = "90 minutos", QuestionId = 1, Correct = true },
                new Option { Id = 2, Description = "120 minutos", QuestionId = 1, Correct = false },
                new Option { Id = 3, Description = "30 minutos", QuestionId = 1, Correct = false },
                new Option { Id = 4, Description = "45 minutos", QuestionId = 1, Correct = false },
                new Option { Id = 5, Description = "Competición de Futbol", QuestionId = 2, Correct = false },
                new Option { Id = 6, Description = "Competición de Tenis", QuestionId = 2, Correct = false },
                new Option { Id = 7, Description = "Competición ciclista", QuestionId = 2, Correct = true },
                new Option { Id = 8, Description = "Competición de Rugby", QuestionId = 2, Correct = false },
                new Option { Id = 9, Description = "Rugby", QuestionId = 3, Correct = false },
                new Option { Id = 10, Description = "Tenis", QuestionId = 3, Correct = false },
                new Option { Id = 11, Description = "Golf", QuestionId = 3, Correct = false },
                new Option { Id = 12, Description = "Futbol Americano ", QuestionId = 3, Correct = true },
                new Option { Id = 13, Description = "Tiro con arco", QuestionId = 4, Correct = false },
                new Option { Id = 14, Description = "Esgrima", QuestionId = 4, Correct = false },
                new Option { Id = 15, Description = "Sumo ", QuestionId = 4, Correct = true },
                new Option { Id = 16, Description = "Karate", QuestionId = 4, Correct = false },
                new Option { Id = 17, Description = "Boxeo ", QuestionId = 5, Correct = true },
                new Option { Id = 18, Description = "Esgrima", QuestionId = 5, Correct = false },
                new Option { Id = 19, Description = "Sumo", QuestionId = 5, Correct = false },
                new Option { Id = 20, Description = "Karate", QuestionId = 5, Correct = false },
                new Option { Id = 21, Description = "8", QuestionId = 6, Correct = false },
                new Option { Id = 22, Description = "7", QuestionId = 6, Correct = true },
                new Option { Id = 23, Description = "9", QuestionId = 6, Correct = false },
                new Option { Id = 24, Description = "6", QuestionId = 6, Correct = false },
                new Option { Id = 25, Description = "Yugi", QuestionId = 7, Correct = true },
                new Option { Id = 26, Description = "Kaiba", QuestionId = 7, Correct = false },
                new Option { Id = 27, Description = "Red", QuestionId = 7, Correct = false },
                new Option { Id = 28, Description = "Tai", QuestionId = 7, Correct = false },
                new Option { Id = 29, Description = "Ryoga", QuestionId = 8, Correct = false },
                new Option { Id = 30, Description = "Mousse", QuestionId = 8, Correct = false },
                new Option { Id = 31, Description = "Shampoo ", QuestionId = 8, Correct = true },
                new Option { Id = 32, Description = "Ukyo ", QuestionId = 8, Correct = false },
                new Option { Id = 33, Description = "Poción de salud", QuestionId = 9, Correct = false },
                new Option { Id = 34, Description = "Agua Sagrada", QuestionId = 9, Correct = false },
                new Option { Id = 35, Description = "Frijol", QuestionId = 9, Correct = false },
                new Option { Id = 36, Description = "Semilla del ermitaño ", QuestionId = 9, Correct = true },
                new Option { Id = 37, Description = "Missa", QuestionId = 10, Correct = false },
                new Option { Id = 38, Description = "Kira", QuestionId = 10, Correct = false },
                new Option { Id = 39, Description = "Ryuk ", QuestionId = 10, Correct = true },
                new Option { Id = 40, Description = "L", QuestionId = 10, Correct = false },
                new Option { Id = 41, Description = "Paulo Poelho", QuestionId = 11, Correct = false },
                new Option { Id = 42, Description = "Gabriel García Márquez ", QuestionId = 11, Correct = true },
                new Option { Id = 43, Description = "Maria Rosa", QuestionId = 11, Correct = false },
                new Option { Id = 44, Description = "Jorge Vargas ", QuestionId = 11, Correct = false },
                new Option { Id = 45, Description = "Francés ", QuestionId = 12, Correct = false },
                new Option { Id = 46, Description = "Latín ", QuestionId = 12, Correct = true },
                new Option { Id = 47, Description = "Árabe", QuestionId = 12, Correct = false },
                new Option { Id = 48, Description = "Ingles ", QuestionId = 12, Correct = false },
                new Option { Id = 49, Description = "Stephen King ", QuestionId = 13, Correct = false },
                new Option { Id = 50, Description = "Gabriel García Márquez", QuestionId = 13, Correct = false },
                new Option { Id = 51, Description = "Julio Cortázar ", QuestionId = 13, Correct = false },
                new Option { Id = 52, Description = "Franz Kafka ", QuestionId = 13, Correct = true },
                new Option { Id = 53, Description = "Stanley Kubrick ", QuestionId = 14, Correct = true },
                new Option { Id = 54, Description = "Stiven Spielberg", QuestionId = 14, Correct = false },
                new Option { Id = 55, Description = "Quentin Tarantino ", QuestionId = 14, Correct = false },
                new Option { Id = 56, Description = "Woody Allen", QuestionId = 14, Correct = false },
                new Option { Id = 57, Description = "George R.R. Martin", QuestionId = 15, Correct = false },
                new Option { Id = 58, Description = "J.R.R. Tolkien ", QuestionId = 15, Correct = true },
                new Option { Id = 59, Description = "J. K. Rowling ", QuestionId = 15, Correct = false },
                new Option { Id = 60, Description = "Edgar Allan Poe", QuestionId = 15, Correct = false },
                new Option { Id = 61, Description = "a+b= C", QuestionId = 16, Correct = false },
                new Option { Id = 62, Description = "E=MC2 ", QuestionId = 16, Correct = true },
                new Option { Id = 63, Description = "E=MC", QuestionId = 16, Correct = false },
                new Option { Id = 64, Description = "a*b*c= d", QuestionId = 16, Correct = false },
                new Option { Id = 65, Description = "Mineral", QuestionId = 17, Correct = false },
                new Option { Id = 66, Description = "Verdoso", QuestionId = 17, Correct = false },
                new Option { Id = 67, Description = "Clarofilia", QuestionId = 17, Correct = false },
                new Option { Id = 68, Description = "Clorofilia", QuestionId = 17, Correct = true },
                new Option { Id = 69, Description = "Tiburón Blanco", QuestionId = 18, Correct = false },
                new Option { Id = 70, Description = "Elefante", QuestionId = 18, Correct = false },
                new Option { Id = 71, Description = "Leon", QuestionId = 18, Correct = false },
                new Option { Id = 72, Description = "Ballena Jorobada ", QuestionId = 18, Correct = true },
                new Option { Id = 73, Description = "Bacterias", QuestionId = 19, Correct = false },
                new Option { Id = 74, Description = "Células", QuestionId = 19, Correct = false },
                new Option { Id = 75, Description = "Material genético y proteínas", QuestionId = 19, Correct = true },
                new Option { Id = 76, Description = "Enfermedades y Microbios ", QuestionId = 19, Correct = false },
                new Option { Id = 77, Description = "Parir", QuestionId = 20, Correct = false },
                new Option { Id = 78, Description = "División Molecular", QuestionId = 20, Correct = false },
                new Option { Id = 79, Description = "Mitosis", QuestionId = 20, Correct = true },
                new Option { Id = 80, Description = "Momentosis ", QuestionId = 20, Correct = false },
                new Option { Id = 81, Description = "90036", QuestionId = 21, Correct = false },
                new Option { Id = 82, Description = "936", QuestionId = 21, Correct = false },
                new Option { Id = 83, Description = "9036", QuestionId = 21, Correct = true },
                new Option { Id = 84, Description = "9360", QuestionId = 21, Correct = false },
                new Option { Id = 85, Description = "Uno", QuestionId = 22, Correct = false },
                new Option { Id = 86, Description = "Cinco", QuestionId = 22, Correct = false },
                new Option { Id = 87, Description = "Diez", QuestionId = 22, Correct = false },
                new Option { Id = 88, Description = "Cuatro", QuestionId = 22, Correct = true },
                new Option { Id = 89, Description = "9", QuestionId = 23, Correct = false },
                new Option { Id = 90, Description = "8", QuestionId = 23, Correct = false },
                new Option { Id = 91, Description = "7", QuestionId = 23, Correct = true },
                new Option { Id = 92, Description = "10", QuestionId = 23, Correct = false },
                new Option { Id = 93, Description = "Multiplicar por tres", QuestionId = 24, Correct = false },
                new Option { Id = 94, Description = "Dividir entre tres", QuestionId = 24, Correct = true },
                new Option { Id = 95, Description = "Restar tres", QuestionId = 24, Correct = false },
                new Option { Id = 96, Description = "Sumar Tres", QuestionId = 24, Correct = false },
                new Option { Id = 97, Description = "Isósceles ", QuestionId = 25, Correct = false },
                new Option { Id = 98, Description = "Escaleno", QuestionId = 25, Correct = true },
                new Option { Id = 99, Description = "Equilátero", QuestionId = 25, Correct = false },
                new Option { Id = 100, Description = "Hexagonal", QuestionId = 25, Correct = false }


               );
        }



        public void AddQuestionsData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>().HasData(
             new Question { Id = 1, Description = "¿Cuánto dura un partido de fútbol?", CategoryId = 1 },
            new Question { Id = 2, Description = "¿Qué selección de fútbol ha ganado más Mundiales?", CategoryId = 1 },
            new Question { Id = 3, Description = "¿Cuánto dura la prórroga en un partido de fútbol?", CategoryId = 1 },
            new Question { Id = 4, Description = "¿Cuántos jugadores tiene un equipo de fútbol en el campo de juego?", CategoryId = 1 },
            new Question { Id = 5, Description = "¿Cómo se llama el estadio del Bayern de Munich?", CategoryId = 1 },
            new Question { Id = 6, Description = "Qué cantidad expresa el número romano V.", CategoryId = 2 },
            new Question { Id = 7, Description = "¿Cuál es el número anterior a 1000?", CategoryId = 2 },
            new Question { Id = 8, Description = "Si en una carrera vas tres puestos por detrás del vigésimo segundo, ¿en qué puesto vas?", CategoryId = 2 },
            new Question { Id = 9, Description = "Un perro pesa 20 kilos y un cachorro pesa 10 kilos menos que él, ¿cuánto pesa la cría?", CategoryId = 2 },
            new Question { Id = 10, Description = "¿Cómo se llama el polígono de siete lados?", CategoryId = 2 },
            new Question { Id = 11, Description = "¿Cuáles son los cinco tipos de sabores primarios?", CategoryId = 3 },
            new Question { Id = 12, Description = "¿Cuál es el lugar más frío de la tierra?", CategoryId = 3 },
            new Question { Id = 13, Description = "¿Quién escribió La Odisea?", CategoryId = 3 },
            new Question { Id = 14, Description = "¿Cómo se llama la capital de Mongolia?", CategoryId = 3 },
            new Question { Id = 15, Description = "¿Cuál es el río más largo del mundo?", CategoryId = 3 },
            new Question { Id = 16, Description = "¿Qué Pokémon tiene bolsillos para acumular electricidad en sus mejillas?", CategoryId = 4 },
            new Question { Id = 17, Description = "¿Qué personaje de anime se vendió al circo?", CategoryId = 4 },
            new Question { Id = 18, Description = "¿Qué serie de anime gira en torno a los hermanos Elric?", CategoryId = 4 },
            new Question { Id = 19, Description = "En el anime «Claymore», ¿quién era el más poderoso de los «Seres despiertos»?", CategoryId = 4 },
            new Question { Id = 20, Description = "Un príncipe marginado se hace cargo de la revolución controlando las mentes de los demás. ¿Quién es él?", CategoryId = 4 },
            new Question { Id = 21, Description = "¿Cuál es el animal más grande que habita la Tierra?", CategoryId = 5 },
            new Question { Id = 22, Description = "¿Qué órgano del cuerpo humano consume más energía?", CategoryId = 5 },
            new Question { Id = 23, Description = "¿En qué galaxia se encuentra la Tierra?", CategoryId = 5 },
            new Question { Id = 24, Description = "¿Cuál es la edad del universo? ", CategoryId = 5 },
            new Question { Id = 25, Description = "¿Cómo se llama a la muerte de cada miembro de una especie? ", CategoryId = 5 }
            );
        }
    }
}

namespace ClassLibrary1
{
    public class Lesson
    {
        private readonly DateTime data; //дата
        public DateTime Data { get => data; }

        private readonly Pair pair;
        public Pair Pair { get => pair; } //ссылка на пару

        private readonly Equipment equipment;
        public Equipment Equipment { get => equipment; }//ссылка на сотрудника

        private readonly TypeLesson typeLesson;
        public TypeLesson TypeLesson { get => typeLesson; }//ссылка на вид занятия

        private readonly Auditory auditory;
        public Auditory Auditory { get => auditory; }//ссылка на аудиторию 

        private readonly Discipline discipline;
        public Discipline Discipline { get => discipline; }//ссылка на дисциплину

        public Lesson(DateTime? data, Pair pair, Equipment equipment,
            TypeLesson typeLesson, Discipline discipline, Auditory auditory)
        {
            this.data = data ?? DateTime.Now;
            this.pair = pair;
            this.equipment = equipment;
            this.typeLesson = typeLesson;
            this.discipline = discipline;
            this.auditory = auditory;
        }
    }
}
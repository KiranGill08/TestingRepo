namespace StudentGrades1.nUnitTests
{
    public class GradeCalculatorTests
    {
        private GradeCalculator _gradeCalculator { get; set; } = null;
        //Default Class for the Testing the program in other project in the same solution 
        [SetUp]
        public void Setup()
        {
            _gradeCalculator = new GradeCalculator();
        }

        [TestCase(30,"F")]
        [TestCase(50, "F")]
        [TestCase(95, "A")]
        public void GetGradeByPercentage_Test(int percentage,string exGrade)
        {
            //Assign 
            //var percentage = 90;

            //Act 
            var grade = _gradeCalculator.GetGradeByPercentage(percentage);

            //Assert
            Assert.AreEqual(exGrade, grade);
        }

        //One has to use testcase annotation  [TestCase()]
    }
}
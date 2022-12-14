namespace MyApplication;

public class LocalData
{
    public const string UserName = "22208021601";
    public const string Password = "123456";


    public static List<DbStudentInfo> StudentInfoList = new List<DbStudentInfo>()
    {
        new DbStudentInfo()
        {
            studentId = "22208021601",
            password = "123456",
            name = "张程瑞",
            sex = "男",
            age = 21,
            major = "软件工程",
            classNum = "软件22216"
        }
    };

    public static List<DbScoreInfo> ScoreInfoList = new List<DbScoreInfo>()
    {
        new DbScoreInfo()
        {
            studentId = "22208021601",
            courseid = "001",
            score = 100
        },
        new DbScoreInfo()
        {
            studentId = "22208021601",
            courseid = "002",
            score = 90
        },
        new DbScoreInfo()
        {
            studentId = "22208021601",
            courseid = "003",
            score = 80
        },
        new DbScoreInfo()
        {
            studentId = "22208021601",
            courseid = "004",
            score = 95
        },
        new DbScoreInfo()
        {
            studentId = "22208021601",
            courseid = "005",
            score = 65
        },
        new DbScoreInfo()
        {
            studentId = "22208021601",
            courseid = "006",
            score = 87
        },
    };

    public static List<DbCourseInfo> CourseInfoList = new List<DbCourseInfo>()
    {
        new DbCourseInfo()
        {
            courseid = "001",
            courseName = "人机交互设计",
            teacher = "赵旭",
            credit = 4
        },
        new DbCourseInfo()
        {
            courseid = "002",
            courseName = "Java",
            teacher = "张三",
            credit = 4
        },
        new DbCourseInfo()
        {
            courseid = "003",
            courseName = "课程3",
            teacher = "李四",
            credit = 4
        },
        new DbCourseInfo()
        {
            courseid = "004",
            courseName = "课程4",
            teacher = "王五",
            credit = 1
        },
        new DbCourseInfo()
        {
            courseid = "005",
            courseName = "课程5",
            teacher = "赵六",
            credit = 4
        },
        new DbCourseInfo()
        {
            courseid = "006",
            courseName = "课程7",
            teacher = "赵七",
            credit = 2
        },
        new DbCourseInfo()
        {
            courseid = "007",
            courseName = "课程8",
            teacher = "赵七",
            credit = 2
        },
        new DbCourseInfo()
        {
            courseid = "008",
            courseName = "课程9",
            teacher = "赵七",
            credit = 2
        },
        new DbCourseInfo()
        {
            courseid = "009",
            courseName = "课程10",
            teacher = "赵七",
            credit = 2
        },
    };
}

public class DbStudentInfo
{
    //学号(作为主键) 姓名 性别 年龄 专业 班级
    public string studentId { get; set; }
    public string password { get; set; }
    public string name { get; set; }
    public string sex { get; set; }
    public int age { get; set; }
    public string major { get; set; }
    public string classNum { get; set; }
}

public class DbScoreInfo
{
    //学号 课程id(作为主键) 成绩
    public string studentId { get; set; }
    public string courseid { get; set; }
    public double score { get; set; }
}

public class DbCourseInfo
{
    //课程id(作为主键) 课程名 授课老师 课程学分
    public string courseid { get; set; }
    public string courseName { get; set; }
    public string teacher { get; set; }
    public double credit { get; set; }
}
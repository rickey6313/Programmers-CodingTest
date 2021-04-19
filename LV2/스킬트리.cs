/*
 * 스킬트리
 * 문제 설명
 * 선행 스킬이란 어떤 스킬을 배우기 전에 먼저 배워야 하는 스킬을 뜻합니다.
 * 
 * 예를 들어 선행 스킬 순서가 스파크 → 라이트닝 볼트 → 썬더일때, 썬더를 배우려면 먼저 라이트닝 볼트를 배워야 하고, 라이트닝 볼트를 배우려면 먼저 스파크를 배워야 합니다.
 * 
 * 위 순서에 없는 다른 스킬(힐링 등)은 순서에 상관없이 배울 수 있습니다. 따라서 스파크 → 힐링 → 라이트닝 볼트 → 썬더와 같은 스킬트리는 가능하지만, 썬더 → 스파크나 라이트닝 볼트 → 스파크 → 힐링 → 썬더와 같은 스킬트리는 불가능합니다.
 * 
 * 선행 스킬 순서 skill과 유저들이 만든 스킬트리1를 담은 배열 skill_trees가 매개변수로 주어질 때, 가능한 스킬트리 개수를 return 하는 solution 함수를 작성해주세요.
 * 
 * 제한 조건
 * 스킬은 알파벳 대문자로 표기하며, 모든 문자열은 알파벳 대문자로만 이루어져 있습니다.
 * 스킬 순서와 스킬트리는 문자열로 표기합니다.
 * 예를 들어, C → B → D 라면 "CBD"로 표기합니다
 * 선행 스킬 순서 skill의 길이는 1 이상 26 이하이며, 스킬은 중복해 주어지지 않습니다.
 * skill_trees는 길이 1 이상 20 이하인 배열입니다.
 * skill_trees의 원소는 스킬을 나타내는 문자열입니다.
 * skill_trees의 원소는 길이가 2 이상 26 이하인 문자열이며, 스킬이 중복해 주어지지 않습니다.
 * 입출력 예
 * skill   skill_trees return
 * "CBD"   ["BACDE", "CBADF", "AECB", "BDA"]   2
 * 입출력 예 설명
 * "BACDE": B 스킬을 배우기 전에 C 스킬을 먼저 배워야 합니다. 불가능한 스킬트립니다.
 * "CBADF": 가능한 스킬트리입니다.
 * "AECB": 가능한 스킬트리입니다.
 * "BDA": B 스킬을 배우기 전에 C 스킬을 먼저 배워야 합니다. 불가능한 스킬트리입니다.
 * 스킬 트리: 유저가 스킬을 배울 순서 ↩
 */

// 상당한 코드 개선이 필요함...

static void Main(string[] args)
{
    string skill = "CBD";
    string[] skill_trees = new string[]
    {
        "BACDE", "CBADF", "AECB", "BDA"
    };

    string skill2 = "ABC";
    string[] skill_trees2 = new string[]
    {
        //"BACDE", "CBADF", 
        //"AECB"
        "C"
        //"BDC", "FDC"
    };

    string skill3 = "CBD";
    string skill4 = "CBD";
    string skill5 = "REA";
    string skill6 = "CBDK";
    string skill7 = "BDC";
    string skill8 = "CBD";

    string[] skill_tree3 = new string[] { "CAD" }; // 0
    string[] skill_tree4 = new string[] { "AEF", "ZJW" }; // 2
    string[] skill_tree5 = new string[] { "REA", "POA" }; // 1
    string[] skill_tree6 = new string[] { "CB", "CXYB", "BD", "AECD", "ABC", "AEX", "CDB", "CBKD", "IJCB", "LMDK"}; // 4
    string[] skill_tree7 = new string[] { "AAAABACA" }; // 0
    string[] skill_tree8 = new string[] { "C", "D", "CB", "BDA" }; // 2
    //Skill_Trees(skill, skill_trees);
    //Skill_Trees(skill2, skill_trees2);

    //Skill_Trees(skill3, skill_tree3);
    //Skill_Trees(skill4, skill_tree4);
    //Skill_Trees(skill5, skill_tree5);
    //Skill_Trees(skill6, skill_tree6);
    //Skill_Trees(skill7, skill_tree7);
    //Skill_Trees(skill8, skill_tree8);
    Skill_Trees("B", skill_tree8);
}

public class Skill
{
    public string index =  string.Empty;

    public Skill previous;
    public Skill post;

    public bool isLearn = false;
    public bool isChecked = false;
    public Skill(string val)
    {
        index = val;
    }
    public void Init()
    {
        isLearn = false;
        isChecked = false;
    }
}

public static int Skill_Trees(string skill, string[] skill_trees)
{   
    int answer = 0;
    if (skill == null || skill.Length == 0)
    {
        Console.WriteLine(skill_trees.Length);
        return skill_trees.Length;
    }

    List<Skill> skills = new List<Skill>();
    for(int i = 0; i < skill.Length; i++)
    {
        skills.Add(new Skill(skill[i].ToString()));
    }
    for(int i = 0; i < skills.Count; i++)
    {
        if(skills.Count == 1)
            break;
        else
        {
            if ((i > 0) && i < skill.Length - 1)
            {
                skills[i].previous = skills[i - 1];
                skills[i].post = skills[i + 1];
            }
            else if (i == 0)
            {
                skills[i].post = skills[i + 1];
            }
            else
                skills[i].previous = skills[i - 1];
        }
    }

    for (int i = 0; i < skill_trees.Length; i++)
    {
        bool collect = true;
        string trees = skill_trees[i];

        for (int k = 0; k < skills.Count; k++)
            skills[k].Init();

        for (int j = 0; j < trees.Length; j++)
        {
            int find = Array.FindIndex(skills.ToArray(), s => s.index == trees[j].ToString());
            //Console.WriteLine($"find index : {find}");

            if (find == -1)
                continue;

            if (skills[find].isChecked)
                continue;

            if(skills.Count == 1)
                continue;
            
            if (skills[find].previous == null && !skills[find].post.isLearn)
            {
                skills[find].isLearn = true;
                skills[find].isChecked = true;
            }
            else if (skills[find].previous != null && skills[find].previous.isLearn)
            {
                skills[find].isLearn = true;
                skills[find].isChecked = true;
            }
            else
                collect = false;
        }

        if (collect)
            answer++;
    }
    Console.WriteLine($"return : {answer}");
    return answer;
}
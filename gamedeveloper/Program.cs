
Attack sulmi1 = new Attack("sulmi1",30);
Attack sulmi2 = new Attack("sulmi2",50);
Attack sulmi3 = new Attack("sulmi3",10);
Attack sulmi4 = new Attack("sulmi4",20);

System.Console.WriteLine(sulmi2.DamageAmount);

Enemy kundershtari2 = new Enemy("armiku2");
Enemy kundershtari1 = new Enemy("kundershtari1");
kundershtari1.AttackList.Add(sulmi1);
kundershtari1.AttackList.Add(sulmi2);
kundershtari1.AttackList.Add(sulmi3);
kundershtari1.AttackList.Add(sulmi4);
kundershtari1.RandomAttackKundershtar(kundershtari2);
kundershtari1.RandomAttackKundershtar(kundershtari2);




public class Attack{
    public string Name;
    public int DamageAmount;

    public Attack(string vleraName,int vleraDmg){
        Name = vleraName;
        DamageAmount= vleraDmg;

    }
    
}

public class Enemy{
    public string Name;
    public int Health=100;
    public List<Attack> AttackList= new List<Attack>();

    public Enemy(string vleraEmrit){
        Name=vleraEmrit;}


public void RandomAttack(){
Random rnd= new Random();
int pozicioniRandom=rnd.Next(AttackList.Count);
Attack sulmRandom = AttackList[pozicioniRandom];
System.Console.WriteLine($" Sulmoj me sulmin {sulmRandom.Name}me demtim{sulmRandom.DamageAmount}");
}
 public void RandomAttackKundershtar(Enemy armiku){
        Random rnd = new Random();
         int pozicioniRandom = rnd.Next(AttackList.Count);
        Attack sulmRandom = AttackList[pozicioniRandom];
        armiku.Health -= sulmRandom.DamageAmount;
        System.Console.WriteLine($" Sulmoj armikun {armiku.Name} me sulmin {sulmRandom.Name} me demtim {sulmRandom.DamageAmount} dhe armikut i ngelet {armiku.Health} jete");
    }
}


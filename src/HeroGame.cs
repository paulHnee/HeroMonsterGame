int heroHealth = 10;
int monsterHealth = 10;
int entityNumber = 1;
string entity = "";


while (monsterHealth > 0 && heroHealth > 0){

int damage = new Random().Next(1,10);
entity = entityNumber == 1 ? "Monster" : "Hero";
int health = entityNumber == 1 ? monsterHealth - damage : heroHealth - damage;

Console.WriteLine($"{entity} was damaged and lost {damage} health and now has {health} health.");
if(entityNumber == 1){
    monsterHealth = monsterHealth - damage;
    entityNumber = 2;
}
else
{
    heroHealth = heroHealth - damage;
    entityNumber = 1;
}
}
if(entity == "Monster"){
Console.WriteLine("Hero wins!");
} else Console.WriteLine("Monster wins!");

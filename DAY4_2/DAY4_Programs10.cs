namespace C_SHARP_PROJECT;
class DAY4_PROGRAM10 : Mother{
protected override void F2() { Console.WriteLine("재정의 된 아들 재산2"); }
static void Main_(String []args){
    DAY4_PROGRAM10 so = new DAY4_PROGRAM10();
    so.F();
    so.F2();
    so.get_info1();
    so.get_info2();
    }
    public void get_info2(){
    base.F2();
    }
}
class GrandMother{
    protected virtual void F() { Console.WriteLine("원본 할머니 재산1"); }
    protected virtual void F2() { Console.WriteLine("원본 할머니 재산2"); }
}

class Mother : GrandMother{
    protected sealed override void F() { Console.WriteLine("엄마 재산 1 제한됨");}
    protected override void F2() { Console.WriteLine("재정의된 엄마 재산2");}
    public void get_info1(){
        base.F2();
    }
}
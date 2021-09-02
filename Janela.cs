public abstract class Janela {
  bool BotaoFechar;
  bool BotaoMax;
  bool BotaoMin;
  string Titulo;
  int PosX;
  int PosY;

  public void setTitulo(string t){
    Titulo = t;
  }

  public virtual void MoverJanela(int x, int y){
    PosX = x;
    PosY = y;
  }

  public Janela (bool bf, bool bmax, bool bmin, string t, int px, int py){
    BotaoFechar = bf;
    BotaoMax    = bmax;
    BotaoMin    = bmin;
    Titulo      = t;
    PosX        = px;
    PosY        = py;
  }



  
}
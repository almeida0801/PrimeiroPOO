namespace PrimeiroPOO
{
    public class personagem
    {
        public string nome= "Tony";

        public int idade = 16;


        public float atacarFraco (float forca, float chute )
        {
            return forca*chute;
        }
        
        public float atacarForte (float forca, float chute, float fogo )
        {
            return forca+chute+fogo;
        }
    }
}
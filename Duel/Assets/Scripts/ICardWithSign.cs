interface ICardWithSign<T> where T: Card    
{
    bool CheckSign(T card);
}

namespace RH.Repositories.Interfaces
{
    public interface IFuncionarioRepository
    {
        public void Obter<T>(T entity) where T : class;
        public void ObterPorUsuarioESenha<T>(T entity) where T : class;
        public void Adicionar<T>(T entity) where T : class;
        public void Editar<T>(T entity) where T : class;
        public void Excluir<T>(T entity) where T : class;
        bool SaveChanges();
    }
}

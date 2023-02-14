using EP.CursoMvc.Application.ViewModels;

namespace EP.CursoMvc.Application.Interfaces
{
    public interface IClienteAppSerivice : IDisposable
    {
        ClienteEnderecoViewModel Adicionar(ClienteEnderecoViewModel clienteEnderecoViewModel);
        ClienteViewModel ObterPorID(Guid id);
        IEnumerable<ClienteViewModel> ObterTodos();
        IEnumerable<ClienteViewModel> ObterAtivos();
        ClienteViewModel ObterPorCpf(string cpf);
        ClienteViewModel Atualizar(ClienteViewModel clienteViewModel);
        void Remover(Guid id);



    }
}
using TreSorelle.ViewModels;

namespace TreSorelle.Services;

public interface IUsuarioService
{
    Task<UsuarioVM> GetUsuarioLogado();
}
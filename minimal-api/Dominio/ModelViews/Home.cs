namespace minimal_api.Dominio.ModelViews
{
    public struct Home
    {
        public string Mensagem { get => "Bem vindo a API."; }
        public string DocumentacaoSwagger { get => "/swagger"; }
        public string DocumentacaoScalar { get => "/api-docs"; }

    }
}
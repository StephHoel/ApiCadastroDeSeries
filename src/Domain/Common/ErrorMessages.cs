namespace Domain.Common;

public static class ErrorMessages
{
    public static class SeriesEndpoints
    {
        public const string IdsNotFound = "Nenhuma série encontrada para os IDs informados";
        public const string NotFoundWithFilter = "Nenhuma série encontrada para o filtro (page e pageSize) informado";
        public const string UpdatedFailed = "Nem todas as séries foram atualizadas com sucesso. Verifique os IDs";
        public const string DeleteFailed = "Nem todas as séries foram deletadas com sucesso. Verifique os IDs";
    }
}
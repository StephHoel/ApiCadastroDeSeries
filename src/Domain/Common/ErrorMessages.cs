namespace Domain.Common;

public static class ErrorMessages
{
    public static class SeriesEndpoints
    {
        public static readonly string IdsNotFound = "Nenhuma série encontrada para os IDs informados";
        public static readonly string NotFoundWithFilter = "Nenhuma série encontrada para o filtro (page e pageSize) informado";
        public static readonly string UpdatedFailed = "Nem todas as séries foram atualizadas com sucesso. Verifique os IDs";
        public static readonly string DeleteFailed = "Nem todas as séries foram deletadas com sucesso. Verifique os IDs";
    }
}
using System.Collections.Generic;
using Center.Production.Chat.Dto;
using Center.Production.Dto;

namespace Center.Production.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(List<ChatMessageExportDto> messages);
    }
}

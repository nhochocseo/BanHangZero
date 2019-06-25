using System.Collections.Generic;
using Center.Production.Auditing.Dto;
using Center.Production.Dto;

namespace Center.Production.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}

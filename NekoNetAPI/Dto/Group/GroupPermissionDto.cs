using MessagePack;
using NekoNet.API.Data;
using NekoNet.API.Data.Enum;

namespace NekoNet.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPermissionDto(GroupData Group, GroupPermissions Permissions) : GroupDto(Group);
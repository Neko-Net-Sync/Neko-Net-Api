using MessagePack;
using NekoNet.API.Data;
using NekoNet.API.Data.Enum;

namespace NekoNet.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPairUserPermissionDto(GroupData Group, UserData User, GroupUserPreferredPermissions GroupPairPermissions) : GroupPairDto(Group, User);
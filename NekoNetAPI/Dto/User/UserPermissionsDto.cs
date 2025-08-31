using MessagePack;
using NekoNet.API.Data;
using NekoNet.API.Data.Enum;

namespace NekoNet.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record UserPermissionsDto(UserData User, UserPermissions Permissions) : UserDto(User);

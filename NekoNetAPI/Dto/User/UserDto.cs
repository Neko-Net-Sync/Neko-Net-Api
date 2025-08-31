using MessagePack;
using NekoNet.API.Data;

namespace NekoNet.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record UserDto(UserData User);
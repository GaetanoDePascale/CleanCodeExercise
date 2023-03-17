// Bad Code
if (
    typeof AUTH_ENABLED === "string" &&
    AUTH_ENABLED === "true" &&
    !skipAuthentication &&
    user &&
    user.email &&
    doAuthenticate(user)
) {
    console.info("Welcome back, " + user.name ?? user.email);
}

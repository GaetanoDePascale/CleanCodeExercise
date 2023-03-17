// Better Code
const isAuthenticationEnabled = typeof AUTH_ENABLED === "string" && AUTH_ENABLED === "true";
const mustAuthenticate = isAuthenticationEnabled && !skipAuthentication;
const isUserAuthenticated = user && user.email && doAuthenticate(user);

if (mustAuthenticate && isUserAuthenticated) {
    console.info("Welcome back, " + user.name ?? user.email);
}

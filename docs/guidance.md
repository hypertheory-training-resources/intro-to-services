# Guidance

## Frontend

### Angular

The frontend is implemented in Angular. It will be built and deployed to a container using Nginx.

State management is handled by Redux using Ngrx.

#### Projects

###### front-end

Within the `frontend` project:

Folder structure:

```
src
    app
        components
            navigation
        containers
            home
```

The _components_ folder is for any components that are meant to be reusable across the appliction (and therefore destined to be in a library), _or_ for components that are used by the `app-component`.

The _containers_ folder is for container components that (usually) the target of routing. Right now there is only one, the `home.component`, that is the "splash" page for entering the application unathenticated.

The _features_ folder is for routable features. We prefer routable feature modules for all areas of functionality. If a feature is deemed to be relatively stable [^1] it _should_ be moved to it's own library module.

#### Testing

## Backend

[^1]:
    This means the churn on this file or set of files indicates that it is no longer being regularly maintained or updated.
    This will need some clarification, but it has a lot to do with testing.

# panosen-codedom-tag
Panosen Code Generation

## install
```
install-package Panosen.CodeDom.Tag.Core
```

## usage
```
    var component = BuildComponent();

    var builder = new StringBuilder();

    new TagEngineCore().Generate(component, builder);

    var actual = builder.ToString();
```
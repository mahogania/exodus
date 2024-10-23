import * as React from "react";
import {
  Create,
  SimpleForm,
  CreateProps,
  ReferenceArrayInput,
  SelectArrayInput,
} from "react-admin";
import { PropertyTitle } from "../property/PropertyTitle";
import { ObjectTypeTitle } from "../objectType/ObjectTypeTitle";

export const PropertyTypeCreate = (props: CreateProps): React.ReactElement => {
  return (
    <Create {...props}>
      <SimpleForm>
        <ReferenceArrayInput
          source="dynamicPropertyInstances"
          reference="Property"
        >
          <SelectArrayInput
            optionText={PropertyTitle}
            parse={(value: any) => value && value.map((v: any) => ({ id: v }))}
            format={(value: any) => value && value.map((v: any) => v.id)}
          />
        </ReferenceArrayInput>
        <ReferenceArrayInput source="objectTypes" reference="ObjectType">
          <SelectArrayInput
            optionText={ObjectTypeTitle}
            parse={(value: any) => value && value.map((v: any) => ({ id: v }))}
            format={(value: any) => value && value.map((v: any) => v.id)}
          />
        </ReferenceArrayInput>
        <div />
      </SimpleForm>
    </Create>
  );
};

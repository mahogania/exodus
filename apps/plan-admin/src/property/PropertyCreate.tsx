import * as React from "react";
import {
  Create,
  SimpleForm,
  CreateProps,
  ReferenceInput,
  SelectInput,
} from "react-admin";
import { PropertyTypeTitle } from "../propertyType/PropertyTypeTitle";
import { ObjectTitle } from "../object/ObjectTitle";

export const PropertyCreate = (props: CreateProps): React.ReactElement => {
  return (
    <Create {...props}>
      <SimpleForm>
        <ReferenceInput
          source="dynamicProperty.id"
          reference="PropertyType"
          label="Dynamic Property"
        >
          <SelectInput optionText={PropertyTypeTitle} />
        </ReferenceInput>
        <ReferenceInput source="object.id" reference="Object" label="Object">
          <SelectInput optionText={ObjectTitle} />
        </ReferenceInput>
        <div />
      </SimpleForm>
    </Create>
  );
};

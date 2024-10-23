import * as React from "react";
import {
  Edit,
  SimpleForm,
  EditProps,
  ReferenceInput,
  SelectInput,
} from "react-admin";
import { PropertyTypeTitle } from "../propertyType/PropertyTypeTitle";
import { ObjectTitle } from "../object/ObjectTitle";

export const PropertyEdit = (props: EditProps): React.ReactElement => {
  return (
    <Edit {...props}>
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
    </Edit>
  );
};

import * as React from "react";
import {
  List,
  Datagrid,
  ListProps,
  ReferenceField,
  TextField,
  DateField,
} from "react-admin";
import Pagination from "../Components/Pagination";
import { ASSOCIATIONTYPE_TITLE_FIELD } from "../associationType/AssociationTypeTitle";

export const AssociationList = (props: ListProps): React.ReactElement => {
  return (
    <List
      {...props}
      title={"Associations"}
      perPage={50}
      pagination={<Pagination />}
    >
      <Datagrid rowClick="show" bulkActionButtons={false}>
        <ReferenceField
          label="Association Type"
          source="associationtype.id"
          reference="AssociationType"
        >
          <TextField source={ASSOCIATIONTYPE_TITLE_FIELD} />
        </ReferenceField>
        <DateField source="createdAt" label="Created At" />
        <TextField label="ID" source="id" />
        <DateField source="updatedAt" label="Updated At" />
        <TextField label="Value" source="value" />{" "}
      </Datagrid>
    </List>
  );
};

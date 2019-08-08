import * as React from 'react';
import { RouteComponentProps } from 'react-router';
import { OrgPaData } from './FetchOrgCA';

interface Props {
    users: OrgPaData[]
    OrgPaData: OrgPaData
    changeUid(o: OrgPaData): void;
}

export class Select extends React.Component<Props> {

    private handleChange(e: React.ChangeEvent<HTMLSelectElement>, oc: OrgPaData) {

        oc.orgPaUid = e.target.value;

        fetch('api/OrgPa/Edit', {
            method: 'PUT',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(oc)
        })
            .then(res => res.text()) // OR res.json()
            .then(res => {
                //console.log(res);
                this.props.changeUid(oc)
            })
    }

    public render() {
        return <div className="form-group">
            <select
                className="form-control"
                id={"select" + this.props.OrgPaData.id}
                onChange={(e) => this.handleChange(e, this.props.OrgPaData)}
                defaultValue={this.props.OrgPaData.orgPaUid}>
                {this.props.users.map(o => <option key={o.id} value={o.orgPaUid}>{o.name}</option>)}
            </select>
        </div>;
    }
}


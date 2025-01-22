using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount
{
	// Token: 0x0200036D RID: 877
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MountHarnessDissociateRequest : IMessage<MountHarnessDissociateRequest>, IMessage, IEquatable<MountHarnessDissociateRequest>, IDeepCloneable<MountHarnessDissociateRequest>, IBufferMessage
	{
		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06002925 RID: 10533 RVA: 0x001C75F8 File Offset: 0x001C57F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MountHarnessDissociateRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06002926 RID: 10534 RVA: 0x001C7608 File Offset: 0x001C5808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06002927 RID: 10535 RVA: 0x001C7618 File Offset: 0x001C5818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x001C7628 File Offset: 0x001C5828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountHarnessDissociateRequest()
		{
		}

		// Token: 0x06002929 RID: 10537 RVA: 0x001C7638 File Offset: 0x001C5838
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountHarnessDissociateRequest(MountHarnessDissociateRequest other)
		{
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x001C7648 File Offset: 0x001C5848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountHarnessDissociateRequest Clone()
		{
			return null;
		}

		// Token: 0x0600292B RID: 10539 RVA: 0x001C7658 File Offset: 0x001C5858
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600292C RID: 10540 RVA: 0x001C7668 File Offset: 0x001C5868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MountHarnessDissociateRequest other)
		{
			return true;
		}

		// Token: 0x0600292D RID: 10541 RVA: 0x001C7678 File Offset: 0x001C5878
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600292E RID: 10542 RVA: 0x001C7688 File Offset: 0x001C5888
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600292F RID: 10543 RVA: 0x001C7698 File Offset: 0x001C5898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002930 RID: 10544 RVA: 0x001C76A8 File Offset: 0x001C58A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002931 RID: 10545 RVA: 0x001C76B8 File Offset: 0x001C58B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002932 RID: 10546 RVA: 0x001C76C8 File Offset: 0x001C58C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MountHarnessDissociateRequest other)
		{
		}

		// Token: 0x06002933 RID: 10547 RVA: 0x001C76D8 File Offset: 0x001C58D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002934 RID: 10548 RVA: 0x001C76E8 File Offset: 0x001C58E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002935 RID: 10549 RVA: 0x001C76F8 File Offset: 0x001C58F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MountHarnessDissociateRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					break;
				case 4:
					MountHarnessDissociateRequest._parser = new MessageParser<MountHarnessDissociateRequest>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x06002936 RID: 10550 RVA: 0x001C77C4 File Offset: 0x001C59C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vE1v9aOrfvOsb9oIucLT()
		{
			return true;
		}

		// Token: 0x06002937 RID: 10551 RVA: 0x001C77CC File Offset: 0x001C59CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MountHarnessDissociateRequest IPLDAtOrnhS5Z9HIde9H()
		{
			return null;
		}

		// Token: 0x04000E99 RID: 3737
		private static readonly MessageParser<MountHarnessDissociateRequest> _parser;

		// Token: 0x04000E9A RID: 3738
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E9B RID: 3739
		private static MountHarnessDissociateRequest Og8iQ5OhzoN34wIBkqTm;
	}
}

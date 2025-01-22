using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management
{
	// Token: 0x0200090F RID: 2319
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CanCreateCharacterRequest : IMessage<CanCreateCharacterRequest>, IMessage, IEquatable<CanCreateCharacterRequest>, IDeepCloneable<CanCreateCharacterRequest>, IBufferMessage
	{
		// Token: 0x17001445 RID: 5189
		// (get) Token: 0x0600707E RID: 28798 RVA: 0x0023B580 File Offset: 0x00239780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CanCreateCharacterRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001446 RID: 5190
		// (get) Token: 0x0600707F RID: 28799 RVA: 0x0023B590 File Offset: 0x00239790
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

		// Token: 0x17001447 RID: 5191
		// (get) Token: 0x06007080 RID: 28800 RVA: 0x0023B5A0 File Offset: 0x002397A0
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

		// Token: 0x06007081 RID: 28801 RVA: 0x0023B5B0 File Offset: 0x002397B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CanCreateCharacterRequest()
		{
		}

		// Token: 0x06007082 RID: 28802 RVA: 0x0023B5C0 File Offset: 0x002397C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CanCreateCharacterRequest(CanCreateCharacterRequest other)
		{
		}

		// Token: 0x06007083 RID: 28803 RVA: 0x0023B5D0 File Offset: 0x002397D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CanCreateCharacterRequest Clone()
		{
			return null;
		}

		// Token: 0x06007084 RID: 28804 RVA: 0x0023B5E0 File Offset: 0x002397E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007085 RID: 28805 RVA: 0x0023B5F0 File Offset: 0x002397F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CanCreateCharacterRequest other)
		{
			return true;
		}

		// Token: 0x06007086 RID: 28806 RVA: 0x0023B600 File Offset: 0x00239800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007087 RID: 28807 RVA: 0x0023B610 File Offset: 0x00239810
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007088 RID: 28808 RVA: 0x0023B620 File Offset: 0x00239820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007089 RID: 28809 RVA: 0x0023B630 File Offset: 0x00239830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600708A RID: 28810 RVA: 0x0023B640 File Offset: 0x00239840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600708B RID: 28811 RVA: 0x0023B650 File Offset: 0x00239850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CanCreateCharacterRequest other)
		{
		}

		// Token: 0x0600708C RID: 28812 RVA: 0x0023B660 File Offset: 0x00239860
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600708D RID: 28813 RVA: 0x0023B670 File Offset: 0x00239870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600708E RID: 28814 RVA: 0x0023B680 File Offset: 0x00239880
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CanCreateCharacterRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					CanCreateCharacterRequest._parser = new MessageParser<CanCreateCharacterRequest>(() => null);
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ec5157afa0544a6c98f5c946af6813ad != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x0600708F RID: 28815 RVA: 0x0023B74C File Offset: 0x0023994C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HGSl2JJeeQVlGAGINxSc()
		{
			return true;
		}

		// Token: 0x06007090 RID: 28816 RVA: 0x0023B754 File Offset: 0x00239954
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CanCreateCharacterRequest DaVPTRJe3Px8Fnkupk0f()
		{
			return null;
		}

		// Token: 0x04002774 RID: 10100
		private static readonly MessageParser<CanCreateCharacterRequest> _parser;

		// Token: 0x04002775 RID: 10101
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002776 RID: 10102
		private static CanCreateCharacterRequest tdOBCHJeBw5Nm141ow7A;
	}
}

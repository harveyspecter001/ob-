using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information
{
	// Token: 0x02000D5B RID: 3419
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceCreationResultEvent : IMessage<AllianceCreationResultEvent>, IMessage, IEquatable<AllianceCreationResultEvent>, IDeepCloneable<AllianceCreationResultEvent>, IBufferMessage
	{
		// Token: 0x17001E95 RID: 7829
		// (get) Token: 0x0600A4BF RID: 42175 RVA: 0x0028FA5C File Offset: 0x0028DC5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceCreationResultEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E96 RID: 7830
		// (get) Token: 0x0600A4C0 RID: 42176 RVA: 0x0028FA6C File Offset: 0x0028DC6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E97 RID: 7831
		// (get) Token: 0x0600A4C1 RID: 42177 RVA: 0x0028FA7C File Offset: 0x0028DC7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A4C2 RID: 42178 RVA: 0x0028FA8C File Offset: 0x0028DC8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceCreationResultEvent()
		{
		}

		// Token: 0x0600A4C3 RID: 42179 RVA: 0x0028FA9C File Offset: 0x0028DC9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceCreationResultEvent(AllianceCreationResultEvent other)
		{
		}

		// Token: 0x0600A4C4 RID: 42180 RVA: 0x0028FAAC File Offset: 0x0028DCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceCreationResultEvent Clone()
		{
			return null;
		}

		// Token: 0x17001E98 RID: 7832
		// (get) Token: 0x0600A4C5 RID: 42181 RVA: 0x0028FABC File Offset: 0x0028DCBC
		// (set) Token: 0x0600A4C6 RID: 42182 RVA: 0x0028FAD0 File Offset: 0x0028DCD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public SocialGroupOperationResult Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (SocialGroupOperationResult)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600A4C7 RID: 42183 RVA: 0x0028FAE0 File Offset: 0x0028DCE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A4C8 RID: 42184 RVA: 0x0028FAF0 File Offset: 0x0028DCF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceCreationResultEvent other)
		{
			return true;
		}

		// Token: 0x0600A4C9 RID: 42185 RVA: 0x0028FB00 File Offset: 0x0028DD00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A4CA RID: 42186 RVA: 0x0028FB10 File Offset: 0x0028DD10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A4CB RID: 42187 RVA: 0x0028FB20 File Offset: 0x0028DD20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A4CC RID: 42188 RVA: 0x0028FB30 File Offset: 0x0028DD30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A4CD RID: 42189 RVA: 0x0028FB40 File Offset: 0x0028DD40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A4CE RID: 42190 RVA: 0x0028FB50 File Offset: 0x0028DD50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceCreationResultEvent other)
		{
		}

		// Token: 0x0600A4CF RID: 42191 RVA: 0x0028FB60 File Offset: 0x0028DD60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A4D0 RID: 42192 RVA: 0x0028FB70 File Offset: 0x0028DD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A4D1 RID: 42193 RVA: 0x0028FB80 File Offset: 0x0028DD80
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceCreationResultEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					AllianceCreationResultEvent._parser = new MessageParser<AllianceCreationResultEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600A4D2 RID: 42194 RVA: 0x0028FC78 File Offset: 0x0028DE78
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ji3YGTJk387AOPJrIUGH()
		{
			return true;
		}

		// Token: 0x0600A4D3 RID: 42195 RVA: 0x0028FC80 File Offset: 0x0028DE80
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceCreationResultEvent xc6brBJkRuvRKukmgqYC()
		{
			return null;
		}

		// Token: 0x04003CA9 RID: 15529
		private static readonly MessageParser<AllianceCreationResultEvent> _parser;

		// Token: 0x04003CAA RID: 15530
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CAB RID: 15531
		public const int ResultFieldNumber = 1;

		// Token: 0x04003CAC RID: 15532
		private SocialGroupOperationResult result_;

		// Token: 0x04003CAD RID: 15533
		private static AllianceCreationResultEvent dtBCFcJkeyxaTtB615RL;
	}
}

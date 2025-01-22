using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Npc
{
	// Token: 0x02000347 RID: 839
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EntityTalkEvent : IMessage<EntityTalkEvent>, IMessage, IEquatable<EntityTalkEvent>, IDeepCloneable<EntityTalkEvent>, IBufferMessage
	{
		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06002756 RID: 10070 RVA: 0x001C3BEC File Offset: 0x001C1DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EntityTalkEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06002757 RID: 10071 RVA: 0x001C3BFC File Offset: 0x001C1DFC
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

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06002758 RID: 10072 RVA: 0x001C3C0C File Offset: 0x001C1E0C
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

		// Token: 0x06002759 RID: 10073 RVA: 0x001C3C1C File Offset: 0x001C1E1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EntityTalkEvent()
		{
		}

		// Token: 0x0600275A RID: 10074 RVA: 0x001C3C2C File Offset: 0x001C1E2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EntityTalkEvent(EntityTalkEvent other)
		{
		}

		// Token: 0x0600275B RID: 10075 RVA: 0x001C3C3C File Offset: 0x001C1E3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EntityTalkEvent Clone()
		{
			return null;
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x0600275C RID: 10076 RVA: 0x001C3C4C File Offset: 0x001C1E4C
		// (set) Token: 0x0600275D RID: 10077 RVA: 0x001C3C5C File Offset: 0x001C1E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x0600275E RID: 10078 RVA: 0x001C3C6C File Offset: 0x001C1E6C
		// (set) Token: 0x0600275F RID: 10079 RVA: 0x001C3C7C File Offset: 0x001C1E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TextId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06002760 RID: 10080 RVA: 0x001C3C8C File Offset: 0x001C1E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> Parameters
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x001C3C9C File Offset: 0x001C1E9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002762 RID: 10082 RVA: 0x001C3CAC File Offset: 0x001C1EAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(EntityTalkEvent other)
		{
			return true;
		}

		// Token: 0x06002763 RID: 10083 RVA: 0x001C3CBC File Offset: 0x001C1EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002764 RID: 10084 RVA: 0x001C3CCC File Offset: 0x001C1ECC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x001C3CDC File Offset: 0x001C1EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002766 RID: 10086 RVA: 0x001C3CEC File Offset: 0x001C1EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x001C3CFC File Offset: 0x001C1EFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002768 RID: 10088 RVA: 0x001C3D0C File Offset: 0x001C1F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(EntityTalkEvent other)
		{
		}

		// Token: 0x06002769 RID: 10089 RVA: 0x001C3D1C File Offset: 0x001C1F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600276A RID: 10090 RVA: 0x001C3D2C File Offset: 0x001C1F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600276B RID: 10091 RVA: 0x001C3D3C File Offset: 0x001C1F3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static EntityTalkEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					EntityTalkEvent._parser = new MessageParser<EntityTalkEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 == 0)
					{
						num2 = 5;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				case 5:
					EntityTalkEvent._repeated_parameters_codec = UhvKwdMSigIudSGM6ge.XVInXhlssT(26U, UhvKwdMSigIudSGM6ge.BvYMM58cmD);
					num2 = 2;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x0600276C RID: 10092 RVA: 0x001C3E3C File Offset: 0x001C203C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Kqaw3mOheXbs9FKgc9FD()
		{
			return true;
		}

		// Token: 0x0600276D RID: 10093 RVA: 0x001C3E44 File Offset: 0x001C2044
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static EntityTalkEvent faR2iZOh30crXtC8hu3G()
		{
			return null;
		}

		// Token: 0x04000E05 RID: 3589
		private static readonly MessageParser<EntityTalkEvent> _parser;

		// Token: 0x04000E06 RID: 3590
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E07 RID: 3591
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04000E08 RID: 3592
		private long entityId_;

		// Token: 0x04000E09 RID: 3593
		public const int TextIdFieldNumber = 2;

		// Token: 0x04000E0A RID: 3594
		private int textId_;

		// Token: 0x04000E0B RID: 3595
		public const int ParametersFieldNumber = 3;

		// Token: 0x04000E0C RID: 3596
		private static readonly FieldCodec<string> _repeated_parameters_codec;

		// Token: 0x04000E0D RID: 3597
		private readonly RepeatedField<string> parameters_;

		// Token: 0x04000E0E RID: 3598
		private static EntityTalkEvent S4bABlOhB6cNQlTecktC;
	}
}

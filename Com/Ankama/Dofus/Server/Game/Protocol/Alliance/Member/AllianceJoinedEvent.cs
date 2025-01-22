using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Member
{
	// Token: 0x02000D42 RID: 3394
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceJoinedEvent : IMessage<AllianceJoinedEvent>, IMessage, IEquatable<AllianceJoinedEvent>, IDeepCloneable<AllianceJoinedEvent>, IBufferMessage
	{
		// Token: 0x17001E5F RID: 7775
		// (get) Token: 0x0600A379 RID: 41849 RVA: 0x0028C8E4 File Offset: 0x0028AAE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceJoinedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E60 RID: 7776
		// (get) Token: 0x0600A37A RID: 41850 RVA: 0x0028C8F4 File Offset: 0x0028AAF4
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

		// Token: 0x17001E61 RID: 7777
		// (get) Token: 0x0600A37B RID: 41851 RVA: 0x0028C904 File Offset: 0x0028AB04
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

		// Token: 0x0600A37C RID: 41852 RVA: 0x0028C914 File Offset: 0x0028AB14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceJoinedEvent()
		{
		}

		// Token: 0x0600A37D RID: 41853 RVA: 0x0028C924 File Offset: 0x0028AB24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceJoinedEvent(AllianceJoinedEvent other)
		{
		}

		// Token: 0x0600A37E RID: 41854 RVA: 0x0028C934 File Offset: 0x0028AB34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceJoinedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001E62 RID: 7778
		// (get) Token: 0x0600A37F RID: 41855 RVA: 0x0028C944 File Offset: 0x0028AB44
		// (set) Token: 0x0600A380 RID: 41856 RVA: 0x0028C954 File Offset: 0x0028AB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AllianceInformation AllianceInformation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001E63 RID: 7779
		// (get) Token: 0x0600A381 RID: 41857 RVA: 0x0028C964 File Offset: 0x0028AB64
		// (set) Token: 0x0600A382 RID: 41858 RVA: 0x0028C974 File Offset: 0x0028AB74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RankId
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

		// Token: 0x0600A383 RID: 41859 RVA: 0x0028C984 File Offset: 0x0028AB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A384 RID: 41860 RVA: 0x0028C994 File Offset: 0x0028AB94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceJoinedEvent other)
		{
			return true;
		}

		// Token: 0x0600A385 RID: 41861 RVA: 0x0028C9A4 File Offset: 0x0028ABA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A386 RID: 41862 RVA: 0x0028C9B4 File Offset: 0x0028ABB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A387 RID: 41863 RVA: 0x0028C9C4 File Offset: 0x0028ABC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A388 RID: 41864 RVA: 0x0028C9D4 File Offset: 0x0028ABD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A389 RID: 41865 RVA: 0x0028C9E4 File Offset: 0x0028ABE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A38A RID: 41866 RVA: 0x0028C9F4 File Offset: 0x0028ABF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceJoinedEvent other)
		{
		}

		// Token: 0x0600A38B RID: 41867 RVA: 0x0028CA04 File Offset: 0x0028AC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A38C RID: 41868 RVA: 0x0028CA14 File Offset: 0x0028AC14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A38D RID: 41869 RVA: 0x0028CA24 File Offset: 0x0028AC24
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceJoinedEvent()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AllianceJoinedEvent._parser = new MessageParser<AllianceJoinedEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
			}
		}

		// Token: 0x0600A38E RID: 41870 RVA: 0x0028CB08 File Offset: 0x0028AD08
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PPTQeNJIoSLP52XjJmku()
		{
			return true;
		}

		// Token: 0x0600A38F RID: 41871 RVA: 0x0028CB10 File Offset: 0x0028AD10
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceJoinedEvent ghXZA6JI1rUOrUX5BI3f()
		{
			return null;
		}

		// Token: 0x04003C49 RID: 15433
		private static readonly MessageParser<AllianceJoinedEvent> _parser;

		// Token: 0x04003C4A RID: 15434
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C4B RID: 15435
		public const int AllianceInformationFieldNumber = 1;

		// Token: 0x04003C4C RID: 15436
		private AllianceInformation allianceInformation_;

		// Token: 0x04003C4D RID: 15437
		public const int RankIdFieldNumber = 2;

		// Token: 0x04003C4E RID: 15438
		private int rankId_;

		// Token: 0x04003C4F RID: 15439
		private static AllianceJoinedEvent rWc0pAJIvGcOKjbVThxD;
	}
}

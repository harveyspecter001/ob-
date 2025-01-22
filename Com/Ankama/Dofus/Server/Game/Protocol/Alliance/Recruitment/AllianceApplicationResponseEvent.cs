using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment
{
	// Token: 0x02000D18 RID: 3352
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceApplicationResponseEvent : IMessage<AllianceApplicationResponseEvent>, IMessage, IEquatable<AllianceApplicationResponseEvent>, IDeepCloneable<AllianceApplicationResponseEvent>, IBufferMessage
	{
		// Token: 0x17001DFF RID: 7679
		// (get) Token: 0x0600A151 RID: 41297 RVA: 0x00288D88 File Offset: 0x00286F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceApplicationResponseEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E00 RID: 7680
		// (get) Token: 0x0600A152 RID: 41298 RVA: 0x00288D98 File Offset: 0x00286F98
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

		// Token: 0x17001E01 RID: 7681
		// (get) Token: 0x0600A153 RID: 41299 RVA: 0x00288DA8 File Offset: 0x00286FA8
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

		// Token: 0x0600A154 RID: 41300 RVA: 0x00288DB8 File Offset: 0x00286FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationResponseEvent()
		{
		}

		// Token: 0x0600A155 RID: 41301 RVA: 0x00288DC8 File Offset: 0x00286FC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationResponseEvent(AllianceApplicationResponseEvent other)
		{
		}

		// Token: 0x0600A156 RID: 41302 RVA: 0x00288DD8 File Offset: 0x00286FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationResponseEvent Clone()
		{
			return null;
		}

		// Token: 0x17001E02 RID: 7682
		// (get) Token: 0x0600A157 RID: 41303 RVA: 0x00288DE8 File Offset: 0x00286FE8
		// (set) Token: 0x0600A158 RID: 41304 RVA: 0x00288DF8 File Offset: 0x00286FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Accepted
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001E03 RID: 7683
		// (get) Token: 0x0600A159 RID: 41305 RVA: 0x00288E08 File Offset: 0x00287008
		// (set) Token: 0x0600A15A RID: 41306 RVA: 0x00288E18 File Offset: 0x00287018
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

		// Token: 0x0600A15B RID: 41307 RVA: 0x00288E28 File Offset: 0x00287028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A15C RID: 41308 RVA: 0x00288E38 File Offset: 0x00287038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceApplicationResponseEvent other)
		{
			return true;
		}

		// Token: 0x0600A15D RID: 41309 RVA: 0x00288E48 File Offset: 0x00287048
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A15E RID: 41310 RVA: 0x00288E58 File Offset: 0x00287058
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A15F RID: 41311 RVA: 0x00288E68 File Offset: 0x00287068
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A160 RID: 41312 RVA: 0x00288E78 File Offset: 0x00287078
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A161 RID: 41313 RVA: 0x00288E88 File Offset: 0x00287088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A162 RID: 41314 RVA: 0x00288E98 File Offset: 0x00287098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceApplicationResponseEvent other)
		{
		}

		// Token: 0x0600A163 RID: 41315 RVA: 0x00288EA8 File Offset: 0x002870A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A164 RID: 41316 RVA: 0x00288EB8 File Offset: 0x002870B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A165 RID: 41317 RVA: 0x00288EC8 File Offset: 0x002870C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceApplicationResponseEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					AllianceApplicationResponseEvent._parser = new MessageParser<AllianceApplicationResponseEvent>(() => null);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b == 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x0600A166 RID: 41318 RVA: 0x00288FAC File Offset: 0x002871AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fuZw9pJKl0D7KqwiroZ5()
		{
			return true;
		}

		// Token: 0x0600A167 RID: 41319 RVA: 0x00288FB4 File Offset: 0x002871B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceApplicationResponseEvent HAVFd4JKcRxOiXugjjaZ()
		{
			return null;
		}

		// Token: 0x04003B99 RID: 15257
		private static readonly MessageParser<AllianceApplicationResponseEvent> _parser;

		// Token: 0x04003B9A RID: 15258
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B9B RID: 15259
		public const int AcceptedFieldNumber = 1;

		// Token: 0x04003B9C RID: 15260
		private bool accepted_;

		// Token: 0x04003B9D RID: 15261
		public const int AllianceInformationFieldNumber = 2;

		// Token: 0x04003B9E RID: 15262
		private AllianceInformation allianceInformation_;

		// Token: 0x04003B9F RID: 15263
		internal static AllianceApplicationResponseEvent G3ashKJKkEtRRa8m8RGW;
	}
}

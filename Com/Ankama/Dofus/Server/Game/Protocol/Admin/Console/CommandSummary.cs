using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Admin.Console
{
	// Token: 0x02000DB6 RID: 3510
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CommandSummary : IMessage<CommandSummary>, IMessage, IEquatable<CommandSummary>, IDeepCloneable<CommandSummary>, IBufferMessage
	{
		// Token: 0x17001F5A RID: 8026
		// (get) Token: 0x0600A916 RID: 43286 RVA: 0x00296514 File Offset: 0x00294714
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CommandSummary> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F5B RID: 8027
		// (get) Token: 0x0600A917 RID: 43287 RVA: 0x00296524 File Offset: 0x00294724
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

		// Token: 0x17001F5C RID: 8028
		// (get) Token: 0x0600A918 RID: 43288 RVA: 0x00296534 File Offset: 0x00294734
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

		// Token: 0x0600A919 RID: 43289 RVA: 0x00296544 File Offset: 0x00294744
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CommandSummary()
		{
		}

		// Token: 0x0600A91A RID: 43290 RVA: 0x00296554 File Offset: 0x00294754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CommandSummary(CommandSummary other)
		{
		}

		// Token: 0x0600A91B RID: 43291 RVA: 0x00296564 File Offset: 0x00294764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CommandSummary Clone()
		{
			return null;
		}

		// Token: 0x17001F5D RID: 8029
		// (get) Token: 0x0600A91C RID: 43292 RVA: 0x00296574 File Offset: 0x00294774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Command> Command
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A91D RID: 43293 RVA: 0x00296584 File Offset: 0x00294784
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A91E RID: 43294 RVA: 0x00296594 File Offset: 0x00294794
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CommandSummary other)
		{
			return true;
		}

		// Token: 0x0600A91F RID: 43295 RVA: 0x002965A4 File Offset: 0x002947A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A920 RID: 43296 RVA: 0x002965B4 File Offset: 0x002947B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A921 RID: 43297 RVA: 0x002965C4 File Offset: 0x002947C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A922 RID: 43298 RVA: 0x002965D4 File Offset: 0x002947D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A923 RID: 43299 RVA: 0x002965E4 File Offset: 0x002947E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A924 RID: 43300 RVA: 0x002965F4 File Offset: 0x002947F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CommandSummary other)
		{
		}

		// Token: 0x0600A925 RID: 43301 RVA: 0x00296604 File Offset: 0x00294804
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A926 RID: 43302 RVA: 0x00296614 File Offset: 0x00294814
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A927 RID: 43303 RVA: 0x00296624 File Offset: 0x00294824
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CommandSummary()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					CommandSummary._repeated_command_codec = FieldCodec.ForMessage<Command>(10U, fgmbYA3gNGdYGlR6PdeB.XVInXhlssT(fgmbYA3gNGdYGlR6PdeB.Dus3gxMn7RM));
					num2 = 5;
					continue;
				case 2:
					CommandSummary._parser = new MessageParser<CommandSummary>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_de04fdfebdbd4a719a239c73a4c6f026 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fdbe83fcafda431197ae585ab85635a6 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_763213b47a3444da994f3672f1295fcd == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 5:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 2;
			}
		}

		// Token: 0x0600A928 RID: 43304 RVA: 0x0029672C File Offset: 0x0029492C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool emkBtWJlz01qeDC3Lk7p()
		{
			return true;
		}

		// Token: 0x0600A929 RID: 43305 RVA: 0x00296734 File Offset: 0x00294934
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CommandSummary EJA0DjJcfw873ZSwmM9S()
		{
			return null;
		}

		// Token: 0x04003E2A RID: 15914
		private static readonly MessageParser<CommandSummary> _parser;

		// Token: 0x04003E2B RID: 15915
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E2C RID: 15916
		public const int CommandFieldNumber = 1;

		// Token: 0x04003E2D RID: 15917
		private static readonly FieldCodec<Command> _repeated_command_codec;

		// Token: 0x04003E2E RID: 15918
		private readonly RepeatedField<Command> command_;

		// Token: 0x04003E2F RID: 15919
		private static CommandSummary GwkWc0JlFd8UVf5gjIWH;
	}
}
